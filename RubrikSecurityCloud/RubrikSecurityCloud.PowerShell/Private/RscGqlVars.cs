using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;

// namespace is RubrikSecurityCloud (and not private)
// because this class is used by the public cmdlets
// and is visible to the user
namespace RubrikSecurityCloud
{
// ignore warning 'Missing XML comment'
#pragma warning disable 1591
    public delegate object GetOverrideValueForVarDelegate(string varName);
#pragma warning restore 1591

    /// <summary>
    /// Variables to be used in a GraphQL query.
    /// </summary>
    public class RscGqlVars : Hashtable
    {
        // variable definitions (comes from the GraphQL schema)
        // keys are variable names
        // values are variable types
        // example:
        // { "clusterId": "String!", "filter": "[ClusterFilterInput!]!" }
        internal Hashtable _varDefs;

        /// <summary>
        /// Create a new RscGqlVars object.
        /// </summary>
        public RscGqlVars()
            : base(StringComparer.OrdinalIgnoreCase)
        {
            _varDefs = new Hashtable(StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Create a new RscGqlVars object.
        /// </summary>
        public RscGqlVars(
            System.Object obj,
            Tuple<String, String>[] varDefs = null,
            GetOverrideValueForVarDelegate getOverrideValueForVar = null,
            bool ignoreRequired = false)
                : this()
        {
            Set(
                obj,
                varDefs,
                getOverrideValueForVar,
                ignoreRequired
            );
        }


        /// <summary>
        /// Set variables from various input types.
        /// </summary>
        /// <param name="obj">
        /// - If varDefs shows only 1 variable, and obj is not a hashtable,
        ///   then obj is assumed to be the value of that variable.
        /// - If obj is a string, it is assumed to be a
        ///   comma-separated list of key-value pairs.
        /// - Otherwise obj must be a hashtable.
        /// Values are converted to JSON-serializable types
        /// (RSC types are passed through as-is).
        /// </param>
        /// <param name="varDefs">
        /// Variable definitions modify the variables in 3 ways:
        /// - look up overrides from the cmdlet's parameters
        /// - throw on missing required variables
        /// - for basic types, convert the value to the correct type
        /// </param>
        /// <param name="getOverrideValueForVar">
        /// Used to look up overrides from the cmdlet's parameters.
        /// </param>
        /// <param name="ignoreRequired">
        /// if false, throw on missing required variables.
        /// </param>
        /// <exception cref="ArgumentException"></exception>
        public void Set(
            System.Object obj,
            Tuple<String, String>[] varDefs = null,
            GetOverrideValueForVarDelegate getOverrideValueForVar = null,
            bool ignoreRequired = false)
        {
            if (varDefs != null && varDefs.Length > 0)
            {
                foreach (var varDef in varDefs)
                {
                    _varDefs.Add(varDef.Item1, varDef.Item2);
                }
            }
            if (obj == null)
            {
                return;
            }

            // special case:
            // if there is only one variable definition
            // and the object is not a hashtable,
            // then we can assume that the object is the value
            if (_varDefs.Count == 1 && !(obj is Hashtable))
            {
                var key = _varDefs.Keys.Cast<object>().First();
                obj = new Hashtable(StringComparer.OrdinalIgnoreCase) {
                    { key, obj }
                };
            }

            // if the object is a string
            // then we can assume that it is a comma-separated list
            // of key-value pairs
            if (obj is String)
            {
                Hashtable h = new Hashtable(StringComparer.OrdinalIgnoreCase);

                // split the String into key-value pairs
                // separated by commas: key1=value1,key2=value2
                string[] pairs = ((string)obj).Split(',');
                foreach (string pair in pairs)
                {
                    string[] kv = pair.Split('=');
                    if (kv.Length != 2)
                    {
                        throw new ArgumentException(
                            string.Format(
                                "Invalid argument {0}. Expected key=value pairs separated by commas.", obj)
                        );
                    }
                    h.Add(kv[0], kv[1]);
                }
                obj = h;
            }

            // Passed argument must be a hashtable
            if (!(obj is Hashtable))
            {
                throw new ArgumentException($"Invalid argument {obj}. Expected a hashtable.");
            }

            // convert obj to this case-insensitive hashtable,
            // coalescing keys with the same name,
            // removing null values,
            // and converting values to JSON-serializable types
            foreach (DictionaryEntry entry in (Hashtable)obj)
            {
                if (entry.Value != null)
                {
                    this.Add(
                        (string)entry.Key,
                        JsonUtils.JsonReady(entry.Value)
                    );
                }
            }

            // Without variable definitions, we're done
            if (_varDefs.Count == 0)
            {
                return;
            }

            conformToVarDefs(getOverrideValueForVar, ignoreRequired);
        }

        /// <summary>
        /// Return documentation links for the variables.
        /// </summary>
        public Hashtable Info()
        {
            var info = new Hashtable(StringComparer.OrdinalIgnoreCase);
            foreach (DictionaryEntry varDef in _varDefs)
            {
                string varName = (string)varDef.Key;
                string varType = (string)varDef.Value;
                var v = StringUtils.DocLinkForGqlType(varType);
                info.Add(varName, v);
            }
            return info;
        }

        /// <summary>
        /// Variable definitions modify the variables in 3 ways:
        /// - look up overrides from the cmdlet's parameters
        /// - throw on missing required variables
        /// - for basic types, convert the value to the correct type
        /// </summary>
        internal void conformToVarDefs(
            GetOverrideValueForVarDelegate getOverrideValueForVar = null,
            bool ignoreRequired = false)
        {

            foreach (DictionaryEntry varDef in _varDefs)
            {
                string varName = (string)varDef.Key;
                string varType = (string)varDef.Value;
                bool isRequired = varType[varType.Length - 1] == '!';
                varType = varType.TrimEnd('!').ToLower();

                // Override if the cmdlet has a parameter with the same name
                if (getOverrideValueForVar != null)
                {
                    var ParamOverride = getOverrideValueForVar(varName);
                    if (ParamOverride != null)
                    {
                        this[varName] = JsonUtils.JsonReady(ParamOverride);
                    }
                }

                if (this.ContainsKey(varName)) // case-insensitive
                {
                    var varValue = this[varName];
                    if (isRequired && varValue == null && !ignoreRequired)
                    {
                        throw new ArgumentException($"Required input {varName} of type {varType} is null.");
                    }

                    // Basic type conversion:
                    if (varValue is String str)
                    {
                        if (varType == "int")
                        {
                            varValue = int.Parse(str);
                        }
                        else if (varType == "bool" || varType == "boolean")
                        {
                            varValue = bool.Parse(str);
                        }
                        else if (varType == "float" || varType == "double")
                        {
                            varValue = float.Parse(str);
                        }
                    }
                    this[varName] = varValue;
                }
                else
                {
                    // variable specified in varDefs wasn't given
                    // we'll send it to the server as null
                    this.Add(varName, null);
                    if (isRequired && !ignoreRequired)
                    {
                        throw new ArgumentException($"Required input {varName} of type {varType} is not provided.");
                    }
                }
            }
        }

        /// <summary>
        /// Convert to a dictionary.
        /// </summary>
        public Dictionary<string, object> ToDict()
        {
            // run again in case user has modified the hashtable
            // directly (with Add() for example) without calling Set()
            conformToVarDefs(null, true);
            return JsonUtils.JsonReady(this) as Dictionary<string, object>;
        }

        /// <summary>
        /// String representation of the variables.
        /// </summary>
        public override string ToString()
        {
            List<string> vars = new();
            foreach (DictionaryEntry entry in this)
            {
                string key = (string)entry.Key;
                if (_varDefs.ContainsKey(key))
                {
                    key += "[" + _varDefs[key] + "]";
                }
                string valStr = "null";
                object val = entry.Value;
                if (val != null)
                {
                    if (val is Hashtable hashTable)
                    {
                        valStr = StringUtils.HashtableToString(hashTable);
                    }
                    else
                    {
                        valStr = val.ToString();
                    }
                    valStr += "<" + val.GetType().Name + ">";
                }
                vars.Add(key + " = " + valStr);
            }
            return string.Join(",", vars);
        }
    }
}