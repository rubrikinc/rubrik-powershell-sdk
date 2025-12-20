// AwsVmConfig.cs
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
    #region AwsVmConfig

    public class AwsVmConfig: IInput
    {
        #region members

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.Int32? NodeSizeGb
        // GraphQL -> nodeSizeGb: Int (scalar)
        [JsonProperty("nodeSizeGb")]
        public System.Int32? NodeSizeGb { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> System.String? Vpc
        // GraphQL -> vpc: String (scalar)
        [JsonProperty("vpc")]
        public System.String? Vpc { get; set; }

        //      C# -> System.String? Tags
        // GraphQL -> tags: String (scalar)
        [JsonProperty("tags")]
        public System.String? Tags { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.String? InstanceProfileName
        // GraphQL -> instanceProfileName: String (scalar)
        [JsonProperty("instanceProfileName")]
        public System.String? InstanceProfileName { get; set; }

        //      C# -> System.String? CdmProduct
        // GraphQL -> cdmProduct: String (scalar)
        [JsonProperty("cdmProduct")]
        public System.String? CdmProduct { get; set; }

        //      C# -> System.String? PlacementGroupName
        // GraphQL -> placementGroupName: String (scalar)
        [JsonProperty("placementGroupName")]
        public System.String? PlacementGroupName { get; set; }

        //      C# -> List<SubnetAzConfigInput>? SubnetAzConfigs
        // GraphQL -> subnetAzConfigs: [SubnetAzConfigInput!] (input)
        [JsonProperty("subnetAzConfigs")]
        public List<SubnetAzConfigInput>? SubnetAzConfigs { get; set; }

        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType (enum)
        [JsonProperty("vmType")]
        public VmType? VmType { get; set; }

        //      C# -> List<System.String>? SecurityGroups
        // GraphQL -> securityGroups: [String!] (scalar)
        [JsonProperty("securityGroups")]
        public List<System.String>? SecurityGroups { get; set; }

        //      C# -> AwsInstanceType? InstanceType
        // GraphQL -> instanceType: AwsInstanceType (enum)
        [JsonProperty("instanceType")]
        public AwsInstanceType? InstanceType { get; set; }

        //      C# -> List<AwsVmNetworkConfig>? NetworkConfig
        // GraphQL -> networkConfig: [AwsVmNetworkConfig!] (input)
        [JsonProperty("networkConfig")]
        public List<AwsVmNetworkConfig>? NetworkConfig { get; set; }


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

    } // class AwsVmConfig
    #endregion

} // namespace RubrikSecurityCloud.Types