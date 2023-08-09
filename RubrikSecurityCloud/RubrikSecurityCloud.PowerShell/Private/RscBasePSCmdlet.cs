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

