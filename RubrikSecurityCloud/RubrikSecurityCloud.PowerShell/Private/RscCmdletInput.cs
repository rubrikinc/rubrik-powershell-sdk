using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Private
{
    public class RscCmdletInput
    {
        public String Op { get; set; }
        public Hashtable Arg { get; set; }
        public Object Field { get; set; }
        internal Tuple<String, String>[] _argDefs = null;
        internal String _gqlOperation = null;
        internal RscBasePSCmdlet _parent = null;

        // For clarity, _logger points to _parent._logger
        internal RscLogger _logger = null;

        public RscCmdletInput(RscBasePSCmdlet parent)
        {
            _parent = parent;
            _logger = parent._logger;
            this.Op = parent.Op;
            this.Arg = new Hashtable();
            this.Field = null;
        }

        /// <summary>
        /// The name of the underlying GQL operation.
        /// </summary>
        /// <returns> String </returns>
        public String GqlOperation() {
            return _gqlOperation;
        }

        private Object _jsonOk(Object obj)
        {
            if (
                obj == null ||
                obj is string ||
                obj is int ||
                obj is bool ||
                obj is IFieldSpec ||
                obj is IInput ||
                obj is Array ||
                obj is Enum
            )
            {
                return obj;
            }
            if (obj is Hashtable hashtable)
            {
                var _arcDict = new Dictionary<string, object>();
                foreach (DictionaryEntry entry in hashtable)
                {
                    if (entry.Value != null)
                    {
                        _arcDict.Add(
                            (string)entry.Key, _jsonOk(entry.Value));
                    }
                }
                return _arcDict;
            }
            // default:
            return obj.ToString();
        }

        internal Dictionary<string, object> GetArgDict()
        {
            var _arcDict = new Dictionary<string, object>();
            foreach (DictionaryEntry entry in this.Arg)
            {
                if (entry.Value != null)
                {
                    _arcDict.Add(
                        (string)entry.Key, _jsonOk(entry.Value));
                }
            }
            return _arcDict;
        }

        internal void Initialize(
            Tuple<String, String>[] argDefs,
            Object field,
            String gqlOperation)
        {
            _argDefs = argDefs;
            this.Field = field;
            // 
            this._gqlOperation = gqlOperation;
            if (argDefs == null || argDefs.Length == 0)
            {
                return;
            }
            Hashtable args = cmdletArgToHashtable();
          
            foreach (var argDef in argDefs)
            {
                String argName = argDef.Item1;
                String argType = argDef.Item2;
                bool isRequired = argType[argType.Length - 1] == '!';
                argType = argType.TrimEnd('!');

                // Override if the cmdlet has a parameter with the same name,
                // within the same parameter set
                var ParamOverride = getValueFromParameterSet(argName);
                if (ParamOverride != null)
                {
                    args[argName] = ParamOverride;
                }

                if (args.ContainsKey(argName)) // case-insensitive
                {
                    var argValue = args[argName];
                    if (isRequired && argValue == null && !_parent.GetInputs)
                    {
                        throw new ArgumentException(
                            String.Format(
                                "Required input {0} of type {1} is null.",
                                argName,
                                argType
                            )
                        );
                    }

                    // non-scalar values in a PowerShell
                    // hashtable are wrapped with PSObject
                    if (argValue is PSObject)
                    {
                        var psObject = (PSObject)argValue;
                        this.Arg.Add(argName, psObject.BaseObject);
                    }
                    else
                    {
                        // Minimal automatic type conversion:
                        if (argValue is String)
                        {
                            String typ = argType.ToLower();
                            if (typ == "int") {
                                argValue = int.Parse((String)argValue);
                            } else if (typ == "bool" || typ == "boolean" ) {
                                argValue = bool.Parse((String)argValue);
                            } else if (typ == "float" || typ == "double") {
                                argValue = float.Parse((String)argValue);
                            }
                        }
                        this.Arg.Add(argName, argValue);
                    }
                }
                else
                {
                    this.Arg.Add(argName, null);
                    if (isRequired && !_parent.GetInputs)
                    {
                        throw new ArgumentException(
                            String.Format(
                                "Required input {0} of type {1} is not provided.",
                                argName,
                                argType
                            )
                        );
                    }
                }
            }
            var FieldStr = this.Field == null ? "null" : this.Field.ToString();
            if ( this.Field != null && this.Field is IFieldSpec ) {
                FieldStr = ((IFieldSpec)this.Field).AsFieldSpec()
                    .Replace("\n"," ");
            }
            _logger.Debug(
                $"RscCmdletInput:\n" +
                $"  Op   : {this.Op}\n" +
                $"  Arg  : {this._argString()}\n" +
                $"  Field: {FieldStr}"
            );
        }

        private Hashtable cmdletArgToHashtable()
        {
            Hashtable args = null;
            if (_argDefs.Length == 1 && !(_parent.Arg is Hashtable))
            {
                args = new Hashtable();
                args.Add(_argDefs[0].Item1, _parent.Arg);
                return args ;
            }
            if (_parent.Arg == null)
            {
                return new Hashtable(StringComparer.OrdinalIgnoreCase);
            }
            if (_parent.Arg is String)
            {
                args = new Hashtable(StringComparer.OrdinalIgnoreCase);
                // split the String into key-value pairs
                // separated by commas: key1=value1,key2=value2
                string[] pairs = ((string)_parent.Arg).Split(',');
                foreach (string pair in pairs)
                {
                    string[] kv = pair.Split('=');
                    if (kv.Length != 2)
                    {
                        throw new ArgumentException(
                            string.Format(
                                "Invalid argument {0}. Expected key=value pairs separated by commas.",
                                _parent.Arg
                            )
                        );
                    }
                    args.Add(kv[0], kv[1]);
                }
                return args ;
            }
            // Hashtable coming from PowerShell is case-insensitive
            return (Hashtable)_parent.Arg;
        }

        internal string _argString()
        {
            List<string> args = new();
            foreach (var argDef in _argDefs)
            {
                string argName = argDef.Item1;
                string argType = argDef.Item2;
                object val = this.Arg[argName];
                string valStr = "null";
                if (val != null)
                {
                    if( val is Hashtable hashTable)
                    {
                        valStr = StringUtils.HashtableToString(hashTable);
                    }
                    else 
                    {
                        valStr = val.ToString();
                    }
                    valStr += "<" + val.GetType().Name + ">";
                    args.Add(argName + "<" + argType + "> = " + valStr);
                }
            }
            return string.Join(",", args);
        }

        private object getValueFromParameterSet(string argName)
        {
            string fieldName = StringUtils.Capitalize(argName);
            Type parentType = _parent.GetType();
            PropertyInfo propertyInfo = parentType.GetProperty(fieldName, BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo == null)
            {
                // _logger.Debug($"No public property with name {fieldName}");
                return null ;
            }
            // there is a public field with the same name
            // but is it a parameter?
            ParameterAttribute parameterAttribute = 
                propertyInfo.GetCustomAttributes(typeof(ParameterAttribute), true).FirstOrDefault() as ParameterAttribute;

            if (parameterAttribute == null )
            {
                // _logger.Debug($"No parameter attribute for field {fieldName}");
                return null ;
            }
            // but is it part of the current parameter set?
            if ( parameterAttribute.ParameterSetName != _parent
                .ParameterSetName)
            {
                // _logger.Debug($"Parameter attribute for field {fieldName} is not in the current parameter set");
                return null;
            }
            // If so, use the value of the parameter
            var argValue = propertyInfo.GetValue(_parent);
            if (argValue == null)
            {
                // _logger.Debug($"Field {fieldName} is null");
                return null;
            }
            return argValue;
        }
    }
}