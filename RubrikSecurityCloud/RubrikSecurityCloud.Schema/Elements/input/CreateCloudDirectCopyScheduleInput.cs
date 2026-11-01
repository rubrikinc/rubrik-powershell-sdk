// CreateCloudDirectCopyScheduleInput.cs
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
    #region CreateCloudDirectCopyScheduleInput

    public class CreateCloudDirectCopyScheduleInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> CopyScheduleTargetType? TargetType
        // GraphQL -> targetType: CopyScheduleTargetType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("targetType")]
        public CopyScheduleTargetType? TargetType { get; set; }

        //      C# -> CopyScheduleFrequency? Frequency
        // GraphQL -> frequency: CopyScheduleFrequency! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("frequency")]
        public CopyScheduleFrequency? Frequency { get; set; }

        //      C# -> System.Int32? FrequencyValue
        // GraphQL -> frequencyValue: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("frequencyValue")]
        public System.Int32? FrequencyValue { get; set; }

        //      C# -> System.String? StartTime
        // GraphQL -> startTime: String! (scalar)
        [Required]
        [JsonRequired]
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

        //      C# -> CopyScheduleDestinationInput? Destination
        // GraphQL -> destination: CopyScheduleDestinationInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("destination")]
        public CopyScheduleDestinationInput? Destination { get; set; }


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

    } // class CreateCloudDirectCopyScheduleInput
    #endregion

} // namespace RubrikSecurityCloud.Types