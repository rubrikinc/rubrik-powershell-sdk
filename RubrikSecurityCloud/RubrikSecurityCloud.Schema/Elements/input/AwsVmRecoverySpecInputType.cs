// AwsVmRecoverySpecInputType.cs
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
    #region AwsVmRecoverySpecInputType

    public class AwsVmRecoverySpecInputType: IInput
    {
        #region members

        //      C# -> System.Int32? InstanceTypeId
        // GraphQL -> instanceTypeId: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceTypeId")]
        public System.Int32? InstanceTypeId { get; set; }

        //      C# -> System.String? InstanceTypeName
        // GraphQL -> instanceTypeName: String (scalar)
        [JsonProperty("instanceTypeName")]
        public System.String? InstanceTypeName { get; set; }

        //      C# -> System.String? HostAffinity
        // GraphQL -> hostAffinity: String (scalar)
        [JsonProperty("hostAffinity")]
        public System.String? HostAffinity { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? DedicatedHostId
        // GraphQL -> dedicatedHostId: String (scalar)
        [JsonProperty("dedicatedHostId")]
        public System.String? DedicatedHostId { get; set; }

        //      C# -> System.String? PlacementGroup
        // GraphQL -> placementGroup: String (scalar)
        [JsonProperty("placementGroup")]
        public System.String? PlacementGroup { get; set; }

        //      C# -> AwsInstanceTenancy? Tenancy
        // GraphQL -> tenancy: AwsInstanceTenancy (enum)
        [JsonProperty("tenancy")]
        public AwsInstanceTenancy? Tenancy { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> List<AwsVmVolumeSpecInputType>? Volumes
        // GraphQL -> volumes: [AwsVmVolumeSpecInputType!] (input)
        [JsonProperty("volumes")]
        public List<AwsVmVolumeSpecInputType>? Volumes { get; set; }

        //      C# -> List<AwsVmNicSpecInputType>? Nics
        // GraphQL -> nics: [AwsVmNicSpecInputType!] (input)
        [JsonProperty("nics")]
        public List<AwsVmNicSpecInputType>? Nics { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }


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

    } // class AwsVmRecoverySpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types