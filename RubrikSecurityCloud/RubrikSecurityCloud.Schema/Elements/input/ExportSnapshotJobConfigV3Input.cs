// ExportSnapshotJobConfigV3Input.cs
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
    #region ExportSnapshotJobConfigV3Input

    public class ExportSnapshotJobConfigV3Input: IInput
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> List<VmwareStorageIdWithDeviceKeyV2Input>? DiskDeviceKeyToStorageId
        // GraphQL -> diskDeviceKeyToStorageId: [VmwareStorageIdWithDeviceKeyV2Input!] (input)
        [JsonProperty("diskDeviceKeyToStorageId")]
        public List<VmwareStorageIdWithDeviceKeyV2Input>? DiskDeviceKeyToStorageId { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String (scalar)
        [JsonProperty("resourcePoolId")]
        public System.String? ResourcePoolId { get; set; }

        //      C# -> System.Boolean? ShouldRecoverTags
        // GraphQL -> shouldRecoverTags: Boolean (scalar)
        [JsonProperty("shouldRecoverTags")]
        public System.Boolean? ShouldRecoverTags { get; set; }

        //      C# -> System.Boolean? ShouldUseHotAddProxy
        // GraphQL -> shouldUseHotAddProxy: Boolean (scalar)
        [JsonProperty("shouldUseHotAddProxy")]
        public System.Boolean? ShouldUseHotAddProxy { get; set; }

        //      C# -> System.String? StorageLocationId
        // GraphQL -> storageLocationId: String (scalar)
        [JsonProperty("storageLocationId")]
        public System.String? StorageLocationId { get; set; }

        //      C# -> System.Boolean? UnregisterVm
        // GraphQL -> unregisterVm: Boolean (scalar)
        [JsonProperty("unregisterVm")]
        public System.Boolean? UnregisterVm { get; set; }

        //      C# -> List<VmwareVnicBindingInfoV2Input>? VnicBindings
        // GraphQL -> vNicBindings: [VmwareVnicBindingInfoV2Input!] (input)
        [JsonProperty("vNicBindings")]
        public List<VmwareVnicBindingInfoV2Input>? VnicBindings { get; set; }

        //      C# -> MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2
        // GraphQL -> mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input (input)
        [JsonProperty("mountExportSnapshotJobCommonOptionsV2")]
        public MountExportSnapshotJobCommonOptionsV2Input? MountExportSnapshotJobCommonOptionsV2 { get; set; }

        //      C# -> RequiredRecoveryParametersInput? RequiredRecoveryParameters
        // GraphQL -> requiredRecoveryParameters: RequiredRecoveryParametersInput (input)
        [JsonProperty("requiredRecoveryParameters")]
        public RequiredRecoveryParametersInput? RequiredRecoveryParameters { get; set; }

        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        [JsonProperty("folderId")]
        public System.String? FolderId { get; set; }


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

    } // class ExportSnapshotJobConfigV3Input
    #endregion

} // namespace RubrikSecurityCloud.Types