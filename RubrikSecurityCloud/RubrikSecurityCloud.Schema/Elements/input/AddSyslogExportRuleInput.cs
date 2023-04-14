// AddSyslogExportRuleInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AddSyslogExportRuleInput

    public class AddSyslogExportRuleInput: IInput
    {
        #region members

        //      C# -> SyslogExportRuleInput? SyslogExportRuleV51
        // GraphQL -> syslogExportRuleV51: SyslogExportRuleInput (input)
        [JsonProperty("syslogExportRuleV51")]
        public SyslogExportRuleInput? SyslogExportRuleV51 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV52
        // GraphQL -> syslogExportRuleV52: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV52")]
        public SyslogExportRuleFullInput? SyslogExportRuleV52 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV53
        // GraphQL -> syslogExportRuleV53: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV53")]
        public SyslogExportRuleFullInput? SyslogExportRuleV53 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV60
        // GraphQL -> syslogExportRuleV60: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV60")]
        public SyslogExportRuleFullInput? SyslogExportRuleV60 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV70
        // GraphQL -> syslogExportRuleV70: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV70")]
        public SyslogExportRuleFullInput? SyslogExportRuleV70 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV80
        // GraphQL -> syslogExportRuleV80: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV80")]
        public SyslogExportRuleFullInput? SyslogExportRuleV80 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV81
        // GraphQL -> syslogExportRuleV81: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV81")]
        public SyslogExportRuleFullInput? SyslogExportRuleV81 { get; set; }

        //      C# -> SyslogExportRuleFullInput? SyslogExportRuleV90
        // GraphQL -> syslogExportRuleV90: SyslogExportRuleFullInput (input)
        [JsonProperty("syslogExportRuleV90")]
        public SyslogExportRuleFullInput? SyslogExportRuleV90 { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


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

    } // class AddSyslogExportRuleInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types