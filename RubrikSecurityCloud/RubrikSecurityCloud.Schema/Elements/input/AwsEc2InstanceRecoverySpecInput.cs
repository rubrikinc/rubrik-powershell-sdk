// AwsEc2InstanceRecoverySpecInput.cs
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
    #region AwsEc2InstanceRecoverySpecInput

    public class AwsEc2InstanceRecoverySpecInput: IInput
    {
        #region members

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> List<System.String>? SecurityGroupNativeIds
        // GraphQL -> securityGroupNativeIds: [String!] (scalar)
        [JsonProperty("securityGroupNativeIds")]
        public List<System.String>? SecurityGroupNativeIds { get; set; }

        //      C# -> System.String? KmsKeyId
        // GraphQL -> kmsKeyId: String (scalar)
        [JsonProperty("kmsKeyId")]
        public System.String? KmsKeyId { get; set; }

        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String (scalar)
        [JsonProperty("sshKeyPairName")]
        public System.String? SshKeyPairName { get; set; }

        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String (scalar)
        [JsonProperty("iamInstanceProfileArn")]
        public System.String? IamInstanceProfileArn { get; set; }

        //      C# -> System.String? VpcNativeId
        // GraphQL -> vpcNativeId: String (scalar)
        [JsonProperty("vpcNativeId")]
        public System.String? VpcNativeId { get; set; }


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

    } // class AwsEc2InstanceRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types