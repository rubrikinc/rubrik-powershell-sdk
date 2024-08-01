// ClusterCapacityQuotaConfigInput.cs
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
    #region ClusterCapacityQuotaConfigInput

    public class ClusterCapacityQuotaConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.Int64? HardLimitGb
        // GraphQL -> hardLimitGb: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hardLimitGb")]
        public System.Int64? HardLimitGb { get; set; }

        //      C# -> System.Int64? SoftLimitGb
        // GraphQL -> softLimitGb: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("softLimitGb")]
        public System.Int64? SoftLimitGb { get; set; }

        //      C# -> ClusterCapacityQuotaType? ClusterCapacityQuotaType
        // GraphQL -> clusterCapacityQuotaType: ClusterCapacityQuotaType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterCapacityQuotaType")]
        public ClusterCapacityQuotaType? ClusterCapacityQuotaType { get; set; }


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

    } // class ClusterCapacityQuotaConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types