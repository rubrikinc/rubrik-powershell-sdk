// FusionComputeVmExportSnapshotJobConfigInput.cs
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
    #region FusionComputeVmExportSnapshotJobConfigInput

    public class FusionComputeVmExportSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: UUID (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetClusterId
        // GraphQL -> targetClusterId: UUID (scalar)
        [JsonProperty("targetClusterId")]
        public System.String? TargetClusterId { get; set; }

        //      C# -> System.Boolean? ShouldPowerOn
        // GraphQL -> shouldPowerOn: Boolean (scalar)
        [JsonProperty("shouldPowerOn")]
        public System.Boolean? ShouldPowerOn { get; set; }

        //      C# -> System.String? TargetDatastoreId
        // GraphQL -> targetDatastoreId: UUID (scalar)
        [JsonProperty("targetDatastoreId")]
        public System.String? TargetDatastoreId { get; set; }

        //      C# -> List<FusionComputeDiskToDatastoreInput>? DiskToDatastoreMap
        // GraphQL -> diskToDatastoreMap: [FusionComputeDiskToDatastoreInput!] (input)
        [JsonProperty("diskToDatastoreMap")]
        public List<FusionComputeDiskToDatastoreInput>? DiskToDatastoreMap { get; set; }

        //      C# -> System.String? RecoveredVmName
        // GraphQL -> recoveredVmName: String (scalar)
        [JsonProperty("recoveredVmName")]
        public System.String? RecoveredVmName { get; set; }

        //      C# -> List<FusionComputeNetworkToNicInput>? NetworkToNicMap
        // GraphQL -> networkToNicMap: [FusionComputeNetworkToNicInput!] (input)
        [JsonProperty("networkToNicMap")]
        public List<FusionComputeNetworkToNicInput>? NetworkToNicMap { get; set; }


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

    } // class FusionComputeVmExportSnapshotJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types