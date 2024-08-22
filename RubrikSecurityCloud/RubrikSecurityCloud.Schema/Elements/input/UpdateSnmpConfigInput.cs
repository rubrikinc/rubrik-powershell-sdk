// UpdateSnmpConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpdateSnmpConfigInput

    public class UpdateSnmpConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SnmpConfigurationInput? SnmpConfigV50
        // GraphQL -> snmpConfigV50: SnmpConfigurationInput (input)
        [JsonProperty("snmpConfigV50")]
        public SnmpConfigurationInput? SnmpConfigV50 { get; set; }

        //      C# -> SnmpConfigurationInput? SnmpConfigV51
        // GraphQL -> snmpConfigV51: SnmpConfigurationInput (input)
        [JsonProperty("snmpConfigV51")]
        public SnmpConfigurationInput? SnmpConfigV51 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV52
        // GraphQL -> snmpConfigV52: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV52")]
        public SnmpConfigurationPatchInput? SnmpConfigV52 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV53
        // GraphQL -> snmpConfigV53: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV53")]
        public SnmpConfigurationPatchInput? SnmpConfigV53 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV60
        // GraphQL -> snmpConfigV60: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV60")]
        public SnmpConfigurationPatchInput? SnmpConfigV60 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV70
        // GraphQL -> snmpConfigV70: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV70")]
        public SnmpConfigurationPatchInput? SnmpConfigV70 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV80
        // GraphQL -> snmpConfigV80: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV80")]
        public SnmpConfigurationPatchInput? SnmpConfigV80 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV81
        // GraphQL -> snmpConfigV81: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV81")]
        public SnmpConfigurationPatchInput? SnmpConfigV81 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV90
        // GraphQL -> snmpConfigV90: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV90")]
        public SnmpConfigurationPatchInput? SnmpConfigV90 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV91
        // GraphQL -> snmpConfigV91: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV91")]
        public SnmpConfigurationPatchInput? SnmpConfigV91 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV92
        // GraphQL -> snmpConfigV92: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV92")]
        public SnmpConfigurationPatchInput? SnmpConfigV92 { get; set; }

        //      C# -> SnmpConfigurationPatchInput? SnmpConfigV93
        // GraphQL -> snmpConfigV93: SnmpConfigurationPatchInput (input)
        [JsonProperty("snmpConfigV93")]
        public SnmpConfigurationPatchInput? SnmpConfigV93 { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class UpdateSnmpConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types