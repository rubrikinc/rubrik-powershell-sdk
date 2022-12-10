// StartExportAzureNativeManagedDiskJobInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartExportAzureNativeManagedDiskJobInput

    public class StartExportAzureNativeManagedDiskJobInput
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        [JsonProperty("diskEncryptionSetNativeId")]
        public System.String? DiskEncryptionSetNativeId { get; set; }

        //      C# -> AzureNativeManagedDiskType? DiskStorageTier
        // GraphQL -> diskStorageTier: AzureNativeManagedDiskType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("diskStorageTier")]
        public AzureNativeManagedDiskType? DiskStorageTier { get; set; }

        //      C# -> System.Int32? DiskSize
        // GraphQL -> diskSize: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("diskSize")]
        public System.Int32? DiskSize { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

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

        //      C# -> System.Boolean? ShouldExportTags
        // GraphQL -> shouldExportTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldExportTags")]
        public System.Boolean? ShouldExportTags { get; set; }

        //      C# -> System.Boolean? ShouldReplaceAttachedManagedDisk
        // GraphQL -> shouldReplaceAttachedManagedDisk: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldReplaceAttachedManagedDisk")]
        public System.Boolean? ShouldReplaceAttachedManagedDisk { get; set; }

        //      C# -> System.Boolean? ShouldUseReplica
        // GraphQL -> shouldUseReplica: Boolean (scalar)
        [JsonProperty("shouldUseReplica")]
        public System.Boolean? ShouldUseReplica { get; set; }

        //      C# -> AzureSnapshotType? SnapshotType
        // GraphQL -> snapshotType: AzureSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public AzureSnapshotType? SnapshotType { get; set; }

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

    } // class StartExportAzureNativeManagedDiskJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types