// HuntScanFileTimeLimitsInputType.cs
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
    #region HuntScanFileTimeLimitsInputType

    public class HuntScanFileTimeLimitsInputType: IInput
    {
        #region members

        //      C# -> DateTime? EarliestCreationTime
        // GraphQL -> earliestCreationTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("earliestCreationTime")]
        public DateTime? EarliestCreationTime { get; set; }

        //      C# -> DateTime? EarliestModificationTime
        // GraphQL -> earliestModificationTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("earliestModificationTime")]
        public DateTime? EarliestModificationTime { get; set; }

        //      C# -> DateTime? LatestCreationTime
        // GraphQL -> latestCreationTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("latestCreationTime")]
        public DateTime? LatestCreationTime { get; set; }

        //      C# -> DateTime? LatestModificationTime
        // GraphQL -> latestModificationTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("latestModificationTime")]
        public DateTime? LatestModificationTime { get; set; }


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

    } // class HuntScanFileTimeLimitsInputType
    #endregion

} // namespace RubrikSecurityCloud.Types