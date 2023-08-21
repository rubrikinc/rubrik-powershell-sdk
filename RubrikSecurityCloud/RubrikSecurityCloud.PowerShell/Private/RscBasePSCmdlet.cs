using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using GraphQL;

namespace RubrikSecurityCloud.PowerShell.Private
{
    /// <summary>
    /// Base class for all RSC PowerShell cmdlets.
    /// </summary>
    public class RscBasePSCmdlet : PSCmdlet
    {
        internal RscLogger _logger = null;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet.
        /// </summary>
        public RscBasePSCmdlet()
        {
            this._logger = new RscLogger(this);
        }

// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            this._logger.Debug(CmdletParametersReport());
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            this._logger.Flush();
        }

        protected void ThrowTerminatingException(Exception ex)
        {
            this._logger?.Flush();
            string message = ex.Message;
            if (ex.InnerException != null)
            {
                message += $"\nInner exception:\n{ex.InnerException.Message}";
            }
            var error = new ErrorRecord(
                new Exception(message),
                this.GetType().Name,
                ErrorCategory.InvalidOperation,
                null);
            ThrowTerminatingError(error);
        }

        protected string GetSessionCWD()
        {
            return SessionState.Path.CurrentFileSystemLocation.Path;
        }

        protected string GetProcessCWD()
        {
            return Directory.GetCurrentDirectory();
        }

        protected string GetSessionVar(string name, string defaultValue = "")
        {
            return SessionState.PSVariable.GetValue(name, defaultValue)?.ToString();
        }

        protected string GetEnvVar(string name, string defaultValue = "")
        {
            return Environment.GetEnvironmentVariable(name) ?? defaultValue;
        }

        protected string GetCustomDir()
        {
            string customDir = this.GetEnvVar("RSC_CUSTOM_DIR");
            if ( string.IsNullOrEmpty(customDir) || 
                 !Directory.Exists(customDir) ) {
                customDir = this.GetSessionCWD();
            }
            return customDir ;
        }

        /// <summary>
        /// Get the RSC SDK's user profile directory.
        /// Typically "$(Split-Path $PROFILE -Parent)/rubrik-powershell-sdk"
        /// But resolves to the current directory if $PROFILE is not defined.
        /// </summary>
        protected string GetProfileDir() 
        {
            string profPath = GetSessionVar("PROFILE");
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Environment.GetEnvironmentVariable("PROFILE");
            }
            // if not defined, use default
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }
            // if not defined, use cwd
            if (string.IsNullOrEmpty(profPath))
            {
                return this.GetSessionCWD();
            }
            // if it's a file, get its directory
            if ( File.Exists(profPath) )
            {
                profPath = Path.GetDirectoryName(profPath);
            } else if (!Directory.Exists(profPath)) {
                // see if parent directory exists
                profPath = Path.GetDirectoryName(profPath);
                if (!Directory.Exists(profPath)) {
                        throw new DirectoryNotFoundException("Could not find: " + profPath);
                }
            }
            profPath= Path.Combine(profPath, "rubrik-powershell-sdk");
            // if it doesn't exist, create it
            if (!Directory.Exists(profPath))
            {
                Directory.CreateDirectory(profPath);
            }
            return profPath;
        }

        /// <summary>
        /// If a cmdlet parameter exists with given name, within the current parameter set, return its value.
        /// </summary>
        internal object GetValueFromParameterSet(string argName)
        {
            string fieldName = StringUtils.Capitalize(argName);
            Type parentType = this.GetType();
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
            if ( parameterAttribute.ParameterSetName != this
                .ParameterSetName)
            {
                // _logger.Debug($"Parameter attribute for field {fieldName} is not in the current parameter set");
                return null;
            }
            // If so, use the value of the parameter
            var argValue = propertyInfo.GetValue(this);
            if (argValue == null)
            {
                // _logger.Debug($"Field {fieldName} is null");
                return null;
            }
            return argValue;
        }

#pragma warning restore 1591

        // For debugging purposes,
        // Create a report of all inputs with their types and values,
        // using introspection to get the names of the parameters.
        internal string CmdletParametersReport(int indent = 0)
        {
            List<string> lines = new();
            var indentStr = new string(' ', indent);
            lines.Add($"{indentStr}Cmdlet Inputs:");
            Type cmdletType = this.GetType();
            string cmdletName = cmdletType.Name;
            System.Reflection.PropertyInfo[] cmdletProperties = cmdletType
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in cmdletProperties)
            {
                // filter for parameters only
                ParameterAttribute parameterAttribute = prop.GetCustomAttributes(typeof(ParameterAttribute), true).FirstOrDefault() as ParameterAttribute;
                if (parameterAttribute == null)
                {
                    continue;
                }
                try
                {
                    var propVal = prop.GetValue(this);
                    if (propVal == null)
                    {
                        continue; // skip unset parameters
                    }
                    var propType = prop.PropertyType;
                    var propTypeName = propType.Name;
                    var paramValueStr = propVal == null ? "null" : propVal.ToString();

                    if (propTypeName == "SwitchParameter" && paramValueStr == "False")
                    {
                        continue; // skip false switch parameters
                    }

                    if (propVal is Hashtable)
                    {
                        // If a Hashtable, print the keys and values
                        paramValueStr = StringUtils.HashtableToString(
                            (Hashtable)propVal);
                    } else if (propVal is IFieldSpec) {
                        // If a IFieldSpec, print the field spec
                        paramValueStr = ((IFieldSpec)propVal).AsFieldSpec()
                            .Replace("\n", " ");
                    }

                    // Display actual type for Object:
                    if (propType is System.Object && propVal != null)
                    {
                        propTypeName = propVal.GetType().Name;
                    }

                    lines.Add($"{indentStr}  {prop.Name} ({propTypeName}): {paramValueStr}");
                }
                catch (Exception e)
                {
                    lines.Add($"{indentStr}  Exception: {e}");
                }
            }
            return string.Join("\n", lines);
        }
    }
}

