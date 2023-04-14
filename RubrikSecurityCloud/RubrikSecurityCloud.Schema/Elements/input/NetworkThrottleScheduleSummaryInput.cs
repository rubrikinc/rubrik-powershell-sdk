// NetworkThrottleScheduleSummaryInput.cs
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
    #region NetworkThrottleScheduleSummaryInput

    public class NetworkThrottleScheduleSummaryInput: IInput
    {
        #region members

        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("daysOfWeek")]
        public List<System.Int32>? DaysOfWeek { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("throttleLimit")]
        public System.Single? ThrottleLimit { get; set; }


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

    } // class NetworkThrottleScheduleSummaryInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types