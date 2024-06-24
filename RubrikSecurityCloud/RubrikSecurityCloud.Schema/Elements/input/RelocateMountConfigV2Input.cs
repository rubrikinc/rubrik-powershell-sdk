// RelocateMountConfigV2Input.cs
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
    #region RelocateMountConfigV2Input

    public class RelocateMountConfigV2Input: IInput
    {
        #region members

        //      C# -> System.String? StorageLocationId
        // GraphQL -> storageLocationId: String (scalar)
        [JsonProperty("storageLocationId")]
        public System.String? StorageLocationId { get; set; }

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String (scalar)
        [JsonProperty("resourcePoolId")]
        public System.String? ResourcePoolId { get; set; }

        //      C# -> List<VmwareStorageIdWithDeviceKeyV2Input>? DiskDeviceKeyToStorageId
        // GraphQL -> diskDeviceKeyToStorageId: [VmwareStorageIdWithDeviceKeyV2Input!] (input)
        [JsonProperty("diskDeviceKeyToStorageId")]
        public List<VmwareStorageIdWithDeviceKeyV2Input>? DiskDeviceKeyToStorageId { get; set; }

        //      C# -> List<VmwareDeviceKeywithNetworkNameV2Input>? NetworkDeviceKeyToNetworkName
        // GraphQL -> networkDeviceKeyToNetworkName: [VmwareDeviceKeywithNetworkNameV2Input!] (input)
        [JsonProperty("networkDeviceKeyToNetworkName")]
        public List<VmwareDeviceKeywithNetworkNameV2Input>? NetworkDeviceKeyToNetworkName { get; set; }


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

    } // class RelocateMountConfigV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types