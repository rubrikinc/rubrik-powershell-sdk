// ProxmoxVmExportSnapshotJobConfigInput.cs
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
    #region ProxmoxVmExportSnapshotJobConfigInput

    public class ProxmoxVmExportSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> System.Int32? VmId
        // GraphQL -> vmId: Int (scalar)
        [JsonProperty("vmId")]
        public System.Int32? VmId { get; set; }

        //      C# -> System.String? StorageId
        // GraphQL -> storageId: String (scalar)
        [JsonProperty("storageId")]
        public System.String? StorageId { get; set; }

        //      C# -> List<DiskToStorageInput>? DiskToStorageMap
        // GraphQL -> diskToStorageMap: [DiskToStorageInput!] (input)
        [JsonProperty("diskToStorageMap")]
        public List<DiskToStorageInput>? DiskToStorageMap { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("networkId")]
        public System.String? NetworkId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }


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

    } // class ProxmoxVmExportSnapshotJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types