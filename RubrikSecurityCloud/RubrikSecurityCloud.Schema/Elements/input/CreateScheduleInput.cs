// CreateScheduleInput.cs
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
    #region CreateScheduleInput

    public class CreateScheduleInput: IInput
    {
        #region members

        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPlanFid")]
        public System.String? RecoveryPlanFid { get; set; }

        //      C# -> DateTime? StartRunTime
        // GraphQL -> startRunTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("startRunTime")]
        public DateTime? StartRunTime { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> ScheduleFrequency? Frequency
        // GraphQL -> frequency: ScheduleFrequency! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("frequency")]
        public ScheduleFrequency? Frequency { get; set; }

        //      C# -> RecoveryConfigInput? RecoveryConfig
        // GraphQL -> recoveryConfig: RecoveryConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryConfig")]
        public RecoveryConfigInput? RecoveryConfig { get; set; }

        //      C# -> List<System.String>? Recipients
        // GraphQL -> recipients: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recipients")]
        public List<System.String>? Recipients { get; set; }


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

    } // class CreateScheduleInput
    #endregion

} // namespace RubrikSecurityCloud.Types