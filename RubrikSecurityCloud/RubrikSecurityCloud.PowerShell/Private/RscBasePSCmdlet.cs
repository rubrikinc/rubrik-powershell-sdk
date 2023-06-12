using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud.Schema.Utils;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.PowerShell.Private
{
    /// <summary>
    /// Base class for all Rubrik Security Cloud PowerShell cmdlets.
    /// </summary>
    public class RscBasePSCmdlet : PSCmdlet
    {
        /// <summary>
        /// Input: Operation to run. Overridden by operation switches.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Op { get; set; }

        /// <summary>
        /// Input: Arguments to the operation. Overridden by argument parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Arg { get; set; }

        /// <summary>
        /// An object that represents the fields that need to be returned
        /// for a given query. Each property on this object that does not
        /// have a null value (actual values don’t matter) will be included 
        /// in the API request.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Field { get; set; }

        /// <summary>
        /// Returns an object that contains the Op, Arg and Field inputs
        /// that would be used to run the operation.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = false)]
        public SwitchParameter GetInputs { get; set; }

        /// <summary>
        /// The input profile determines how inputs to the operation
        /// should be automatically set if they are not explicitly given
        /// as parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipeline = false)]
        public Exploration.Profile InputProfile { get; set; }

        internal RscLogger _logger = null;

        /// <summary>
        /// Create a new Rubrik Security Cloud PowerShell cmdlet.
        /// </summary>
        public RscBasePSCmdlet()
        {
            this._logger = new RscLogger(this);
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            Exploration.GlobalProfile = this.InputProfile;
            this._logger.Debug(CmdletParametersReport());
            if (string.IsNullOrEmpty(Op))
            {
                Op = ParameterSetName ;
            }
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
                    if (propType is Object && propVal != null)
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

