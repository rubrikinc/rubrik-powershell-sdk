// StartEc2InstanceSnapshotExportJobInput.cs
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
    #region StartEc2InstanceSnapshotExportJobInput

    public class StartEc2InstanceSnapshotExportJobInput: IInput
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

        //      C# -> AwsNativeEc2InstanceType? InstanceType
        // GraphQL -> instanceType: AwsNativeEc2InstanceType (enum)
        [JsonProperty("instanceType")]
        public AwsNativeEc2InstanceType? InstanceType { get; set; }

        //      C# -> System.String? Ec2InstanceType
        // GraphQL -> ec2InstanceType: String (scalar)
        [JsonProperty("ec2InstanceType")]
        public System.String? Ec2InstanceType { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> List<System.String>? SecurityGroupIds
        // GraphQL -> securityGroupIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("securityGroupIds")]
        public List<System.String>? SecurityGroupIds { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> AwsNativeRegion? DestinationRegionId
        // GraphQL -> destinationRegionId: AwsNativeRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegionId")]
        public AwsNativeRegion? DestinationRegionId { get; set; }

        //      C# -> System.Boolean? ShouldCopyTags
        // GraphQL -> shouldCopyTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCopyTags")]
        public System.Boolean? ShouldCopyTags { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String (scalar)
        [JsonProperty("sshKeyPairName")]
        public System.String? SshKeyPairName { get; set; }

        //      C# -> System.Boolean? ExportInstanceInPoweredOffState
        // GraphQL -> exportInstanceInPoweredOffState: Boolean (scalar)
        [JsonProperty("exportInstanceInPoweredOffState")]
        public System.Boolean? ExportInstanceInPoweredOffState { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String (scalar)
        [JsonProperty("amiId")]
        public System.String? AmiId { get; set; }

        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String (scalar)
        [JsonProperty("iamInstanceProfileArn")]
        public System.String? IamInstanceProfileArn { get; set; }

        //      C# -> System.String? ArchivedSnapshotId
        // GraphQL -> archivedSnapshotId: UUID (scalar)
        [JsonProperty("archivedSnapshotId")]
        public System.String? ArchivedSnapshotId { get; set; }

        //      C# -> System.String? DedicatedHostId
        // GraphQL -> dedicatedHostId: String (scalar)
        [JsonProperty("dedicatedHostId")]
        public System.String? DedicatedHostId { get; set; }

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

    } // class StartEc2InstanceSnapshotExportJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types