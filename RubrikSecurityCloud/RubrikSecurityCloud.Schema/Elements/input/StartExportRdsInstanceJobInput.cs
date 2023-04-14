// StartExportRdsInstanceJobInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartExportRdsInstanceJobInput

    public class StartExportRdsInstanceJobInput: IInput
    {
        #region members

        //      C# -> System.String? RdsInstanceId
        // GraphQL -> rdsInstanceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rdsInstanceId")]
        public System.String? RdsInstanceId { get; set; }

        //      C# -> System.Boolean? IsPointInTime
        // GraphQL -> isPointInTime: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isPointInTime")]
        public System.Boolean? IsPointInTime { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? ExportTime
        // GraphQL -> exportTime: DateTime (scalar)
        [JsonProperty("exportTime")]
        public DateTime? ExportTime { get; set; }

        //      C# -> System.String? DbInstanceName
        // GraphQL -> dbInstanceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dbInstanceName")]
        public System.String? DbInstanceName { get; set; }

        //      C# -> System.String? DestinationAwsNativeAccountId
        // GraphQL -> destinationAwsNativeAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationAwsNativeAccountId")]
        public System.String? DestinationAwsNativeAccountId { get; set; }

        //      C# -> AwsNativeRegion? DestinationRegionNativeId
        // GraphQL -> destinationRegionNativeId: AwsNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegionNativeId")]
        public AwsNativeRegion? DestinationRegionNativeId { get; set; }

        //      C# -> AwsNativeRdsDbInstanceClass? DbInstanceClass
        // GraphQL -> dbInstanceClass: AwsNativeRdsDbInstanceClass! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("dbInstanceClass")]
        public AwsNativeRdsDbInstanceClass? DbInstanceClass { get; set; }

        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String (scalar)
        [JsonProperty("primaryAz")]
        public System.String? PrimaryAz { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }

        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String (scalar)
        [JsonProperty("optionGroupName")]
        public System.String? OptionGroupName { get; set; }

        //      C# -> System.String? ParameterGroupName
        // GraphQL -> parameterGroupName: String (scalar)
        [JsonProperty("parameterGroupName")]
        public System.String? ParameterGroupName { get; set; }

        //      C# -> System.String? SubnetGroupName
        // GraphQL -> subnetGroupName: String (scalar)
        [JsonProperty("subnetGroupName")]
        public System.String? SubnetGroupName { get; set; }

        //      C# -> AwsNativeRdsStorageType? StorageType
        // GraphQL -> storageType: AwsNativeRdsStorageType (enum)
        [JsonProperty("storageType")]
        public AwsNativeRdsStorageType? StorageType { get; set; }

        //      C# -> List<System.String>? SecurityGroupIds
        // GraphQL -> securityGroupIds: [String!] (scalar)
        [JsonProperty("securityGroupIds")]
        public List<System.String>? SecurityGroupIds { get; set; }

        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int (scalar)
        [JsonProperty("iops")]
        public System.Int32? Iops { get; set; }

        //      C# -> System.Boolean? IsPubliclyAccessible
        // GraphQL -> isPubliclyAccessible: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isPubliclyAccessible")]
        public System.Boolean? IsPubliclyAccessible { get; set; }

        //      C# -> System.Boolean? ShouldExportTags
        // GraphQL -> shouldExportTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldExportTags")]
        public System.Boolean? ShouldExportTags { get; set; }

        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isMultiAz")]
        public System.Boolean? IsMultiAz { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> List<System.String>? SubnetIds
        // GraphQL -> subnetIds: [String!] (scalar)
        [JsonProperty("subnetIds")]
        public List<System.String>? SubnetIds { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? DbClusterName
        // GraphQL -> dbClusterName: String (scalar)
        [JsonProperty("dbClusterName")]
        public System.String? DbClusterName { get; set; }

        //      C# -> System.String? DbClusterParameterGroupName
        // GraphQL -> dbClusterParameterGroupName: String (scalar)
        [JsonProperty("dbClusterParameterGroupName")]
        public System.String? DbClusterParameterGroupName { get; set; }


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

    } // class StartExportRdsInstanceJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types