// StartExportAzureNativeVirtualMachineJobInput.cs
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
    #region StartExportAzureNativeVirtualMachineJobInput

    public class StartExportAzureNativeVirtualMachineJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VirtualMachineName
        // GraphQL -> virtualMachineName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("virtualMachineName")]
        public System.String? VirtualMachineName { get; set; }

        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        [JsonProperty("diskEncryptionSetNativeId")]
        public System.String? DiskEncryptionSetNativeId { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> AzureNativeRegion? DestinationRegion
        // GraphQL -> destinationRegion: AzureNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegion")]
        public AzureNativeRegion? DestinationRegion { get; set; }

        //      C# -> System.String? DestinationAvailabilityZone
        // GraphQL -> destinationAvailabilityZone: String (scalar)
        [JsonProperty("destinationAvailabilityZone")]
        public System.String? DestinationAvailabilityZone { get; set; }

        //      C# -> System.String? DestinationSubscriptionRubrikId
        // GraphQL -> destinationSubscriptionRubrikId: UUID (scalar)
        [JsonProperty("destinationSubscriptionRubrikId")]
        public System.String? DestinationSubscriptionRubrikId { get; set; }

        //      C# -> System.String? VirtualMachineSize
        // GraphQL -> virtualMachineSize: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("virtualMachineSize")]
        public System.String? VirtualMachineSize { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> System.String? NetworkSecurityGroupNativeId
        // GraphQL -> networkSecurityGroupNativeId: String (scalar)
        [JsonProperty("networkSecurityGroupNativeId")]
        public System.String? NetworkSecurityGroupNativeId { get; set; }

        //      C# -> System.Boolean? ShouldExportTags
        // GraphQL -> shouldExportTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldExportTags")]
        public System.Boolean? ShouldExportTags { get; set; }

        //      C# -> System.Boolean? ShouldPowerOff
        // GraphQL -> shouldPowerOff: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldPowerOff")]
        public System.Boolean? ShouldPowerOff { get; set; }

        //      C# -> System.Boolean? ShouldUseReplica
        // GraphQL -> shouldUseReplica: Boolean (scalar)
        [JsonProperty("shouldUseReplica")]
        public System.Boolean? ShouldUseReplica { get; set; }

        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String (scalar)
        [JsonProperty("availabilitySetNativeId")]
        public System.String? AvailabilitySetNativeId { get; set; }

        //      C# -> System.Boolean? ShouldEnableAcceleratedNetworking
        // GraphQL -> shouldEnableAcceleratedNetworking: Boolean (scalar)
        [JsonProperty("shouldEnableAcceleratedNetworking")]
        public System.Boolean? ShouldEnableAcceleratedNetworking { get; set; }

        //      C# -> AzureSnapshotType? SnapshotType
        // GraphQL -> snapshotType: AzureSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public AzureSnapshotType? SnapshotType { get; set; }

        //      C# -> List<System.String>? RecoveryDiskIds
        // GraphQL -> recoveryDiskIds: [UUID!] (scalar)
        [JsonProperty("recoveryDiskIds")]
        public List<System.String>? RecoveryDiskIds { get; set; }

        //      C# -> System.String? ArchivedSnapshotId
        // GraphQL -> archivedSnapshotId: UUID (scalar)
        [JsonProperty("archivedSnapshotId")]
        public System.String? ArchivedSnapshotId { get; set; }

        //      C# -> System.String? DestinationKeyVaultName
        // GraphQL -> destinationKeyVaultName: String (scalar)
        [JsonProperty("destinationKeyVaultName")]
        public System.String? DestinationKeyVaultName { get; set; }


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

    } // class StartExportAzureNativeVirtualMachineJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types