// StartRecoverDynamoDbSnapshotJobInput.cs
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
    #region StartRecoverDynamoDbSnapshotJobInput

    public class StartRecoverDynamoDbSnapshotJobInput: IInput
    {
        #region members

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? RecoveryDate
        // GraphQL -> recoveryDate: DateTime (scalar)
        [JsonProperty("recoveryDate")]
        public DateTime? RecoveryDate { get; set; }

        //      C# -> System.String? TargetAwsAccountRubrikId
        // GraphQL -> targetAwsAccountRubrikId: UUID (scalar)
        [JsonProperty("targetAwsAccountRubrikId")]
        public System.String? TargetAwsAccountRubrikId { get; set; }

        //      C# -> AwsNativeRegion? DestinationRegion
        // GraphQL -> destinationRegion: AwsNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegion")]
        public AwsNativeRegion? DestinationRegion { get; set; }

        //      C# -> System.Int32? MaxRecoveryWcus
        // GraphQL -> maxRecoveryWcus: Int (scalar)
        [JsonProperty("maxRecoveryWcus")]
        public System.Int32? MaxRecoveryWcus { get; set; }

        //      C# -> System.String? RecoveredTableName
        // GraphQL -> recoveredTableName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveredTableName")]
        public System.String? RecoveredTableName { get; set; }

        //      C# -> System.Boolean? ExportTags
        // GraphQL -> exportTags: Boolean (scalar)
        [JsonProperty("exportTags")]
        public System.Boolean? ExportTags { get; set; }

        //      C# -> System.Boolean? IncludeSecondaryIndexes
        // GraphQL -> includeSecondaryIndexes: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includeSecondaryIndexes")]
        public System.Boolean? IncludeSecondaryIndexes { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.Boolean? PreferRecoveryFromArchivedCopy
        // GraphQL -> preferRecoveryFromArchivedCopy: Boolean (scalar)
        [JsonProperty("preferRecoveryFromArchivedCopy")]
        public System.Boolean? PreferRecoveryFromArchivedCopy { get; set; }

        //      C# -> AwsRetrievalTier? RetrievalTier
        // GraphQL -> retrievalTier: AwsRetrievalTier (enum)
        [JsonProperty("retrievalTier")]
        public AwsRetrievalTier? RetrievalTier { get; set; }

        //      C# -> DynamoDbRestoreDestination? RestoreDestination
        // GraphQL -> restoreDestination: DynamoDbRestoreDestination (enum)
        [JsonProperty("restoreDestination")]
        public DynamoDbRestoreDestination? RestoreDestination { get; set; }

        //      C# -> DynamoDbRestoreSearchInput? Search
        // GraphQL -> search: DynamoDbRestoreSearchInput (input)
        [JsonProperty("search")]
        public DynamoDbRestoreSearchInput? Search { get; set; }

        //      C# -> DynamoDbRestoreOverwriteInput? Overwrite
        // GraphQL -> overwrite: DynamoDbRestoreOverwriteInput (input)
        [JsonProperty("overwrite")]
        public DynamoDbRestoreOverwriteInput? Overwrite { get; set; }

        //      C# -> DynamoDbRestoreTtlInput? Ttl
        // GraphQL -> ttl: DynamoDbRestoreTtlInput (input)
        [JsonProperty("ttl")]
        public DynamoDbRestoreTtlInput? Ttl { get; set; }

        //      C# -> DynamoDbRestoreCustomAttributeInput? CustomAttribute
        // GraphQL -> customAttribute: DynamoDbRestoreCustomAttributeInput (input)
        [JsonProperty("customAttribute")]
        public DynamoDbRestoreCustomAttributeInput? CustomAttribute { get; set; }

        //      C# -> DynamoDbS3ExportTargetInput? S3ExportTarget
        // GraphQL -> s3ExportTarget: DynamoDbS3ExportTargetInput (input)
        [JsonProperty("s3ExportTarget")]
        public DynamoDbS3ExportTargetInput? S3ExportTarget { get; set; }


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

    } // class StartRecoverDynamoDbSnapshotJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types