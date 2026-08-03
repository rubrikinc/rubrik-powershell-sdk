// AzureNativeVmRecoverySpecInput.cs
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
    #region AzureNativeVmRecoverySpecInput

    public class AzureNativeVmRecoverySpecInput: IInput
    {
        #region members

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String (scalar)
        [JsonProperty("sizeType")]
        public System.String? SizeType { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.Boolean? ShouldEnableAcceleratedNetworking
        // GraphQL -> shouldEnableAcceleratedNetworking: Boolean (scalar)
        [JsonProperty("shouldEnableAcceleratedNetworking")]
        public System.Boolean? ShouldEnableAcceleratedNetworking { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> System.String? NetworkSecurityGroupNativeId
        // GraphQL -> networkSecurityGroupNativeId: String (scalar)
        [JsonProperty("networkSecurityGroupNativeId")]
        public System.String? NetworkSecurityGroupNativeId { get; set; }

        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String (scalar)
        [JsonProperty("availabilitySetNativeId")]
        public System.String? AvailabilitySetNativeId { get; set; }

        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        [JsonProperty("diskEncryptionSetNativeId")]
        public System.String? DiskEncryptionSetNativeId { get; set; }


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

    } // class AzureNativeVmRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types