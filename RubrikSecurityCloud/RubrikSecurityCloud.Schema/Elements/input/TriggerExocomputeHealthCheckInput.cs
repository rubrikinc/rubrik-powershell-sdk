// TriggerExocomputeHealthCheckInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TriggerExocomputeHealthCheckInput

    public class TriggerExocomputeHealthCheckInput
    {
        #region members
        //      C# -> CloudVendor? CloudVendor
        // GraphQL -> cloudVendor: CloudVendor! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudVendor")]
        public CloudVendor? CloudVendor { get; set; }

        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exocomputeConfigId")]
        public System.String? ExocomputeConfigId { get; set; }

        //      C# -> System.String? NodeType
        // GraphQL -> nodeType: String (scalar)
        [JsonProperty("nodeType")]
        public System.String? NodeType { get; set; }

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

    } // class TriggerExocomputeHealthCheckInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types