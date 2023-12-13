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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

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
    public class RscGqlVars : VarDict
    {
        // variable definitions (comes from the GraphQL schema)
        // keys are variable names
        // values are variable types
        // example:
        // { "clusterId": "String!", "filter": "[ClusterFilterInput!]!" }
        internal VarDict _varDefs;

        // an example of how the variables can
        // be initialized
        internal string _example;

        /// <summary>
        /// Create a new RscGqlVars object.
        /// </summary>
        public RscGqlVars()
        {
            _varDefs = new VarDict();
        }

        /// <summary>
        /// Create a new RscGqlVars object.
        /// </summary>
        public RscGqlVars(
            System.Object obj,
            Tuple<String, String>[] varDefs = null,
            GetOverrideValueForVarDelegate getOverrideValueForVar = null,
            bool ignoreRequired = false,
            string example = null)
                : this()
        {
            Set(
                obj,
                varDefs,
                getOverrideValueForVar,
                ignoreRequired,
                example
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
        /// - Otherwise obj must be a hashtable
        ///   (obj=null is treated as an empty hashtable).
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
        /// <param name="example">
        /// An example of how the variables can be initialized.
        /// </param>
        /// <exception cref="ArgumentException"></exception>
        public void Set(
            System.Object obj,
            Tuple<String, String>[] varDefs = null,
            GetOverrideValueForVarDelegate getOverrideValueForVar = null,
            bool ignoreRequired = false,
            string example = null)
        {
            if (RubrikSecurityCloud.Config.IgnoreMissingRequiredVariables)
            {
                ignoreRequired = true;
            }

            _example = example;
            _varDefs.AddFromTuple(varDefs);

            // if obj is null, treat it as an empty hashtable
            if (obj == null)
            {
                obj = new VarDict();
            }
            else if (obj is Hashtable objHash)
            {
                obj = new VarDict(objHash);
            }

            // special case #1:
            // if there is only one variable definition
            // and the object is not a hashtable,
            // or is a hashtable without the variable name as a key,
            // then we can assume that the object is the value
            if (_varDefs.Count == 1)
            {
                string key = _varDefs.Keys.Cast<object>().First().ToString();
                if (obj is VarDict objVd)
                {
                    if (objVd.Count == 1 && objVd.ContainsKey(key))
                    {
                        // obj is good as-is
                    }
                    else
                    {
                        obj = new VarDict() {
                            { key, obj }
                        };
                    }
                }
                else
                {
                    obj = new VarDict() {
                        { key, obj }
                    };
                }
            }

            // special case #2:
            // if the object is a string
            // then we can assume that it is a comma-separated list
            // of key-value pairs
            if (obj is String sObj)
            {
                var vd = new VarDict();
                vd.AddFromCskvString(sObj);
                obj = vd;
            }

            // Passed argument must be a hashtable
            if (obj is not VarDict)
            {
                throw new ArgumentException($"Invalid argument {obj}. Expected a hashtable.");
            }

            // start by populating with _varDefs with null values,
            // so that if a variable is specified with a different
            // case, it will coalesce with the correct case
            // (the one from varDefs).
            // (remaining null entries will be ignored).
            foreach (string key in _varDefs.Keys)
            {
                this.Add(key, null);
            }

            // read obj, coalescing keys with the same name,
            // removing null values,
            // and converting values to JSON-serializable types
            foreach (KeyValuePair<string, object> entry in (VarDict)obj)
            {
                if (entry.Value != null)
                {
                    var v = JsonUtils.JsonReady(entry.Value);
                    if (this.ContainsKey(entry.Key))
                    {
                        this[entry.Key] = v;
                    }
                    else
                    {
                        this.Add(entry.Key, v);
                    }
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
        /// Return info about the variables:
        /// - name
        /// - type
        /// - link to online documentation
        /// </summary>
        public List<VarInfo> Info()
        {
            var info = new List<VarInfo>();
            foreach (KeyValuePair<string, object> varDef in _varDefs)
            {
                string varName = (string)varDef.Key;
                string varGqlType = (string)varDef.Value;
                string VarDescr = StringUtils.DocLinkForGqlType(varGqlType);
                string varType = StringUtils.GqlTypeToType(varGqlType);
                info.Add(new VarInfo(
                    varName,
                    varType,
                    $"{varGqlType}: {VarDescr}"));
            }
            return info;
        }

        /// <summary>
        /// Return an example of how the variables can be initialized.
        /// </summary>
        public string Example()
        {
            return _example;
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
            if (RubrikSecurityCloud.Config.IgnoreMissingRequiredVariables)
            {
                ignoreRequired = true;
            }

            foreach (KeyValuePair<string, object> varDef in _varDefs)
            {
                string varName = (string)varDef.Key;
                string varTypeExpr = (string)varDef.Value;
                bool isRequired = varTypeExpr[varTypeExpr.Length - 1] == '!';
                string varType = varTypeExpr.TrimEnd('!').ToLower();

                // Override if the cmdlet has a parameter with the same name
                if (getOverrideValueForVar != null)
                {
                    var ParamOverride = getOverrideValueForVar(varName);
                    if (ParamOverride != null)
                    {
                        this[varName] = JsonUtils.JsonReady(ParamOverride);
                    }
                }

                // throw if required and missing
                if (isRequired && !ignoreRequired &&
                    (!this.ContainsKey(varName) || this[varName] == null))
                {
                    var t = varTypeExpr.TrimEnd('!');
                    var ns = "RubrikSecurityCloud.Types.";
                    // Try to get the type with the namespace prefix
                    Type typeWithNamespace = Type.GetType(ns + t);

                    // Use the namespace prefix only if the type exists in that namespace
                    var typ = typeWithNamespace != null ? ns + t : t;
                    throw new ArgumentException("Required variable '" +
                        varName + "' of type [" + typ + "] is missing.");
                }

                if (this.ContainsKey(varName)) // case-insensitive
                {
                    var varValue = this[varName];

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
                    } else if (varValue is int iVarValue ) {
                        if ( varType == "string" ) {
                            varValue = iVarValue.ToString();
                        }
                    }
                    this[varName] = varValue;
                }
                else
                {
                    // variable specified in varDefs wasn't given
                    // we'll send it to the server as null
                    this.Add(varName, null);
                }
            }
        }

        /// <summary>
        /// Finalize the variables for sending to the server:
        /// - perform basic conversions to match var definitions
        ///   (e.g.: a value of "3" is converted to 3
        ///          where the var def says int)
        /// - check for missing required variables
        /// - make sure all variables are JSON-serializable.
        /// </summary>
        public VarDict Finalize()
        {
            // run again in case user has modified the hashtable
            // directly (with Add() for example) without calling Set()
            conformToVarDefs();
            return JsonUtils.JsonReady(this) as VarDict;
        }

        /// <summary>
        /// String representation of the variables.
        /// </summary>
        public override string ToString()
        {
            List<string> vars = new();
            foreach (KeyValuePair<string, object> entry in this)
            {
                string key = (string)entry.Key;
                if (_varDefs.ContainsKey(key))
                {
                    key += "[gql:" + _varDefs[key] + "]";
                }
                string valStr = StringUtils.FormatObjectForLogging(entry.Value);
                vars.Add(key + " = " + valStr);
            }
            return string.Join(",", vars);
        }
    }
}