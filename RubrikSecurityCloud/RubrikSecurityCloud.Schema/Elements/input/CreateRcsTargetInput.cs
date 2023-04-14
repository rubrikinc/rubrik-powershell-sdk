// CreateRcsTargetInput.cs
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
    #region CreateRcsTargetInput

    public class CreateRcsTargetInput: IInput
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

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }

        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceType")]
        public InstanceTypeEnum? InstanceType { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }

        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public RcsRegionEnumType? Region { get; set; }

        //      C# -> System.Int32? SpaceUsageAlertThreshold
        // GraphQL -> spaceUsageAlertThreshold: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("spaceUsageAlertThreshold")]
        public System.Int32? SpaceUsageAlertThreshold { get; set; }

        //      C# -> System.Int64? LockDurationDays
        // GraphQL -> lockDurationDays: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("lockDurationDays")]
        public System.Int64? LockDurationDays { get; set; }


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

    } // class CreateRcsTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types