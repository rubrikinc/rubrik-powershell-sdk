// UpdateSyslogExportRuleInput.cs
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
    #region UpdateSyslogExportRuleInput

    public class UpdateSyslogExportRuleInput: IInput
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

        //      C# -> SyslogExportRuleUpdateInput? SyslogSettingsV51
        // GraphQL -> syslogSettingsV51: SyslogExportRuleUpdateInput (input)
        [JsonProperty("syslogSettingsV51")]
        public SyslogExportRuleUpdateInput? SyslogSettingsV51 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV52
        // GraphQL -> syslogSettingsV52: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV52")]
        public SyslogExportRulePartialInput? SyslogSettingsV52 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV53
        // GraphQL -> syslogSettingsV53: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV53")]
        public SyslogExportRulePartialInput? SyslogSettingsV53 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV60
        // GraphQL -> syslogSettingsV60: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV60")]
        public SyslogExportRulePartialInput? SyslogSettingsV60 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV70
        // GraphQL -> syslogSettingsV70: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV70")]
        public SyslogExportRulePartialInput? SyslogSettingsV70 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV80
        // GraphQL -> syslogSettingsV80: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV80")]
        public SyslogExportRulePartialInput? SyslogSettingsV80 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV81
        // GraphQL -> syslogSettingsV81: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV81")]
        public SyslogExportRulePartialInput? SyslogSettingsV81 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV90
        // GraphQL -> syslogSettingsV90: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV90")]
        public SyslogExportRulePartialInput? SyslogSettingsV90 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV91
        // GraphQL -> syslogSettingsV91: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV91")]
        public SyslogExportRulePartialInput? SyslogSettingsV91 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV92
        // GraphQL -> syslogSettingsV92: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV92")]
        public SyslogExportRulePartialInput? SyslogSettingsV92 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV93
        // GraphQL -> syslogSettingsV93: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV93")]
        public SyslogExportRulePartialInput? SyslogSettingsV93 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV94
        // GraphQL -> syslogSettingsV94: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV94")]
        public SyslogExportRulePartialInput? SyslogSettingsV94 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV95
        // GraphQL -> syslogSettingsV95: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV95")]
        public SyslogExportRulePartialInput? SyslogSettingsV95 { get; set; }

        //      C# -> SyslogExportRulePartialInput? SyslogSettingsV96
        // GraphQL -> syslogSettingsV96: SyslogExportRulePartialInput (input)
        [JsonProperty("syslogSettingsV96")]
        public SyslogExportRulePartialInput? SyslogSettingsV96 { get; set; }


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

    } // class UpdateSyslogExportRuleInput
    #endregion

} // namespace RubrikSecurityCloud.Types