// AwsRdsInstanceRecoverySpecInput.cs
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
    #region AwsRdsInstanceRecoverySpecInput

    public class AwsRdsInstanceRecoverySpecInput: IInput
    {
        #region members

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.String? DbInstanceClass
        // GraphQL -> dbInstanceClass: String (scalar)
        [JsonProperty("dbInstanceClass")]
        public System.String? DbInstanceClass { get; set; }

        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String (scalar)
        [JsonProperty("dbEngineVersion")]
        public System.String? DbEngineVersion { get; set; }

        //      C# -> System.Boolean? IsMultiAz
        // GraphQL -> isMultiAz: Boolean (scalar)
        [JsonProperty("isMultiAz")]
        public System.Boolean? IsMultiAz { get; set; }

        //      C# -> System.String? PrimaryAz
        // GraphQL -> primaryAz: String (scalar)
        [JsonProperty("primaryAz")]
        public System.String? PrimaryAz { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }

        //      C# -> System.String? StorageType
        // GraphQL -> storageType: String (scalar)
        [JsonProperty("storageType")]
        public System.String? StorageType { get; set; }

        //      C# -> System.Int64? Iops
        // GraphQL -> iops: Long (scalar)
        [JsonProperty("iops")]
        public System.Int64? Iops { get; set; }

        //      C# -> System.String? VpcNativeId
        // GraphQL -> vpcNativeId: String (scalar)
        [JsonProperty("vpcNativeId")]
        public System.String? VpcNativeId { get; set; }

        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!] (scalar)
        [JsonProperty("securityGroupNativeIds")]
        public List<System.String>? SecurityGroupNativeIds { get; set; }

        //      C# -> System.String? SubnetGroupName
        // GraphQL -> subnetGroupName: String (scalar)
        [JsonProperty("subnetGroupName")]
        public System.String? SubnetGroupName { get; set; }

        //      C# -> System.Boolean? IsPubliclyAccessible
        // GraphQL -> isPubliclyAccessible: Boolean (scalar)
        [JsonProperty("isPubliclyAccessible")]
        public System.Boolean? IsPubliclyAccessible { get; set; }

        //      C# -> System.String? OptionGroupName
        // GraphQL -> optionGroupName: String (scalar)
        [JsonProperty("optionGroupName")]
        public System.String? OptionGroupName { get; set; }

        //      C# -> System.String? ParameterGroupName
        // GraphQL -> parameterGroupName: String (scalar)
        [JsonProperty("parameterGroupName")]
        public System.String? ParameterGroupName { get; set; }

        //      C# -> System.String? ClusterParameterGroupName
        // GraphQL -> clusterParameterGroupName: String (scalar)
        [JsonProperty("clusterParameterGroupName")]
        public System.String? ClusterParameterGroupName { get; set; }


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

    } // class AwsRdsInstanceRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types