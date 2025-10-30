// StartExportAwsNativeEbsVolumeSnapshotJobInput.cs
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
    #region StartExportAwsNativeEbsVolumeSnapshotJobInput

    public class StartExportAwsNativeEbsVolumeSnapshotJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? DestinationAwsAccountRubrikId
        // GraphQL -> destinationAwsAccountRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationAwsAccountRubrikId")]
        public System.String? DestinationAwsAccountRubrikId { get; set; }

        //      C# -> AwsNativeRegion? DestinationRegionNativeId
        // GraphQL -> destinationRegionNativeId: AwsNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegionNativeId")]
        public AwsNativeRegion? DestinationRegionNativeId { get; set; }

        //      C# -> System.String? VolumeName
        // GraphQL -> volumeName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeName")]
        public System.String? VolumeName { get; set; }

        //      C# -> System.Int32? VolumeSize
        // GraphQL -> volumeSize: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeSize")]
        public System.Int32? VolumeSize { get; set; }

        //      C# -> AwsNativeEbsVolumeType? VolumeType
        // GraphQL -> volumeType: AwsNativeEbsVolumeType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("volumeType")]
        public AwsNativeEbsVolumeType? VolumeType { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("iops")]
        public System.Int32? Iops { get; set; }

        //      C# -> System.Boolean? ShouldCopyTags
        // GraphQL -> shouldCopyTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCopyTags")]
        public System.Boolean? ShouldCopyTags { get; set; }

        //      C# -> System.Boolean? ShouldReplaceAttached
        // GraphQL -> shouldReplaceAttached: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldReplaceAttached")]
        public System.Boolean? ShouldReplaceAttached { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? ArchivedSnapshotId
        // GraphQL -> archivedSnapshotId: UUID (scalar)
        [JsonProperty("archivedSnapshotId")]
        public System.String? ArchivedSnapshotId { get; set; }

        //      C# -> System.Boolean? ShouldResurrectSnapshot
        // GraphQL -> shouldResurrectSnapshot: Boolean (scalar)
        [JsonProperty("shouldResurrectSnapshot")]
        public System.Boolean? ShouldResurrectSnapshot { get; set; }


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

    } // class StartExportAwsNativeEbsVolumeSnapshotJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types