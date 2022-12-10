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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.PowerShell.Private
{
    public class RscBasePSCmdlet : PSCmdlet
    {
        //
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public String Op { get; set; }

        //
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public Object Arg { get; set; }

        //
        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public Object Field { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = false)]
        public SwitchParameter GetInputs { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipeline = false)]
        public Exploration.Profile InputProfile { get; set; }

        internal RscLogger _logger = null;

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

        // For debugging purposes,
        // Create a report of all inputs with their types and values,
        // using introspection to get the names of the parameters.
        internal String CmdletParametersReport(int indent = 0)
        {
            List<string> lines = new List<string>();
            var indentStr = new String(' ', indent);
            lines.Add($"{indentStr}Cmdlet Inputs:");
            Type cmdletType = this.GetType();
            String cmdletName = cmdletType.Name;
            System.Reflection.PropertyInfo[] cmdletProperties = cmdletType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
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
                        paramValueStr = StringUtils.HashtableToString((Hashtable)propVal);
                    } else if (propVal is IFragment) {
                        // If a IFragment, print the fragment
                        paramValueStr = ((IFragment)propVal).AsFragment().Replace("\n", " ");
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
            return String.Join("\n", lines);
        }

    }

}

