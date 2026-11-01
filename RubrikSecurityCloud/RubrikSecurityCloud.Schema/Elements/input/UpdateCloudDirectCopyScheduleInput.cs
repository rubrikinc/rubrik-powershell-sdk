// UpdateCloudDirectCopyScheduleInput.cs
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
    #region UpdateCloudDirectCopyScheduleInput

    public class UpdateCloudDirectCopyScheduleInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? ScheduleId
        // GraphQL -> scheduleId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("scheduleId")]
        public System.String? ScheduleId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? FrequencyValue
        // GraphQL -> frequencyValue: Int (scalar)
        [JsonProperty("frequencyValue")]
        public System.Int32? FrequencyValue { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String (scalar)
        [JsonProperty("startTime")]
        public System.String? StartTime { get; set; }

        //      C# -> System.Int32? DayOfWeek
        // GraphQL -> dayOfWeek: Int (scalar)
        [JsonProperty("dayOfWeek")]
        public System.Int32? DayOfWeek { get; set; }

        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int (scalar)
        [JsonProperty("dayOfMonth")]
        public System.Int32? DayOfMonth { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? DestinationShareId
        // GraphQL -> destinationShareId: UUID (scalar)
        [JsonProperty("destinationShareId")]
        public System.String? DestinationShareId { get; set; }

        //      C# -> CopyScheduleCloudTargetInput? CloudTarget
        // GraphQL -> cloudTarget: CopyScheduleCloudTargetInput (input)
        [JsonProperty("cloudTarget")]
        public CopyScheduleCloudTargetInput? CloudTarget { get; set; }


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

    } // class UpdateCloudDirectCopyScheduleInput
    #endregion

} // namespace RubrikSecurityCloud.Types