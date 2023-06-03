// CreateAwsComputeSettingInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateAwsComputeSettingInput

    public class CreateAwsComputeSettingInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> System.Boolean? IsSecurityGroupPolarisManaged
        // GraphQL -> isSecurityGroupPolarisManaged: Boolean (scalar)
        [JsonProperty("isSecurityGroupPolarisManaged")]
        public System.Boolean? IsSecurityGroupPolarisManaged { get; set; }

        //      C# -> List<ClusterInfCidrsInput>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrsInput!] (input)
        [JsonProperty("clusterInterfaceCidrs")]
        public List<ClusterInfCidrsInput>? ClusterInterfaceCidrs { get; set; }


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

    } // class CreateAwsComputeSettingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types