// ScheduleInfoV2.cs
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
    #region ScheduleInfoV2

    public class ScheduleInfoV2: IInput
    {
        #region members

        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime (scalar)
        [JsonProperty("startRunTime")]
        public DateTime? StartRunTime { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("frequency")]
        public ScheduleFrequency? Frequency { get; set; }

        //      C# -> RecoveryConfigV2? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfigV2 (input)
        [JsonProperty("recoveryConfig")]
        public RecoveryConfigV2? RecoveryConfig { get; set; }

        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!] (scalar)
        [JsonProperty("recipients")]
        public List<System.String>? Recipients { get; set; }

        //      C# -> System.Boolean? ExcludeReportInEmail
        // GraphQL -> excludeReportInEmail: Boolean (scalar)
        [JsonProperty("excludeReportInEmail")]
        public System.Boolean? ExcludeReportInEmail { get; set; }


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

    } // class ScheduleInfoV2
    #endregion

} // namespace RubrikSecurityCloud.Types