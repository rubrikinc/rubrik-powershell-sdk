// GcpNativeExportDiskInput.cs
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
    #region GcpNativeExportDiskInput

    public class GcpNativeExportDiskInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetRegion
        // GraphQL -> targetRegion: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetRegion")]
        public System.String? TargetRegion { get; set; }

        //      C# -> System.String? TargetZone
        // GraphQL -> targetZone: String (scalar)
        [JsonProperty("targetZone")]
        public System.String? TargetZone { get; set; }

        //      C# -> System.String? TargetDiskName
        // GraphQL -> targetDiskName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDiskName")]
        public System.String? TargetDiskName { get; set; }

        //      C# -> System.String? TargetDiskType
        // GraphQL -> targetDiskType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDiskType")]
        public System.String? TargetDiskType { get; set; }

        //      C# -> System.Int32? TargetDiskSizeGb
        // GraphQL -> targetDiskSizeGb: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDiskSizeGb")]
        public System.Int32? TargetDiskSizeGb { get; set; }

        //      C# -> System.Boolean? ReplaceAttached
        // GraphQL -> replaceAttached: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("replaceAttached")]
        public System.Boolean? ReplaceAttached { get; set; }

        //      C# -> List<System.String>? ReplicaZones
        // GraphQL -> replicaZones: [String!] (scalar)
        [JsonProperty("replicaZones")]
        public List<System.String>? ReplicaZones { get; set; }

        //      C# -> System.Boolean? ShouldCopyLabels
        // GraphQL -> shouldCopyLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCopyLabels")]
        public System.Boolean? ShouldCopyLabels { get; set; }

        //      C# -> System.Boolean? ShouldAddRubrikLabels
        // GraphQL -> shouldAddRubrikLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldAddRubrikLabels")]
        public System.Boolean? ShouldAddRubrikLabels { get; set; }

        //      C# -> DiskEncryptionType? DiskEncryptionType
        // GraphQL -> diskEncryptionType: DiskEncryptionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("diskEncryptionType")]
        public DiskEncryptionType? DiskEncryptionType { get; set; }

        //      C# -> KmsCryptoKey? KmsCryptoKey
        // GraphQL -> kmsCryptoKey: KmsCryptoKey (input)
        [JsonProperty("kmsCryptoKey")]
        public KmsCryptoKey? KmsCryptoKey { get; set; }

        //      C# -> System.String? KmsCryptoKeyResourceId
        // GraphQL -> kmsCryptoKeyResourceId: String (scalar)
        [JsonProperty("kmsCryptoKeyResourceId")]
        public System.String? KmsCryptoKeyResourceId { get; set; }

        //      C# -> System.String? TargetGcpProjectRubrikId
        // GraphQL -> targetGcpProjectRubrikId: UUID (scalar)
        [JsonProperty("targetGcpProjectRubrikId")]
        public System.String? TargetGcpProjectRubrikId { get; set; }


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

    } // class GcpNativeExportDiskInput
    #endregion

} // namespace RubrikSecurityCloud.Types