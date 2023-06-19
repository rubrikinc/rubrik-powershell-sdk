// CloudNativeDownloadFilesInput.cs
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
    #region CloudNativeDownloadFilesInput

    public class CloudNativeDownloadFilesInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<System.String>? FilePaths
        // GraphQL -> filePaths: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("filePaths")]
        public List<System.String>? FilePaths { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> FileRecoveryLocationDetailsInput? FileRecoveryLocationDetails
        // GraphQL -> fileRecoveryLocationDetails: FileRecoveryLocationDetailsInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("fileRecoveryLocationDetails")]
        public FileRecoveryLocationDetailsInput? FileRecoveryLocationDetails { get; set; }

        //      C# -> FileDownloadType? DownloadType
        // GraphQL -> downloadType: FileDownloadType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("downloadType")]
        public FileDownloadType? DownloadType { get; set; }

        //      C# -> System.String? ExocomputeCloudNativeAccountId
        // GraphQL -> exocomputeCloudNativeAccountId: UUID (scalar)
        [JsonProperty("exocomputeCloudNativeAccountId")]
        public System.String? ExocomputeCloudNativeAccountId { get; set; }

        //      C# -> System.String? ExocomputeRegion
        // GraphQL -> exocomputeRegion: String (scalar)
        [JsonProperty("exocomputeRegion")]
        public System.String? ExocomputeRegion { get; set; }


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

    } // class CloudNativeDownloadFilesInput
    #endregion

} // namespace RubrikSecurityCloud.Types