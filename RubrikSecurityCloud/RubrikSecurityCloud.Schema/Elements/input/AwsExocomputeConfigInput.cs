// AwsExocomputeConfigInput.cs
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
    #region AwsExocomputeConfigInput

    public class AwsExocomputeConfigInput: IInput
    {
        #region members

        //      C# -> AwsCloudAccountRegion? Region
        // GraphQL -> region: AwsCloudAccountRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AwsCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? ClusterSecurityGroupId
        // GraphQL -> clusterSecurityGroupId: String (scalar)
        [JsonProperty("clusterSecurityGroupId")]
        public System.String? ClusterSecurityGroupId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? NodeSecurityGroupId
        // GraphQL -> nodeSecurityGroupId: String (scalar)
        [JsonProperty("nodeSecurityGroupId")]
        public System.String? NodeSecurityGroupId { get; set; }

        //      C# -> List<AwsExocomputeSubnetInputType>? Subnets
        // GraphQL -> subnets: [AwsExocomputeSubnetInputType!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("subnets")]
        public List<AwsExocomputeSubnetInputType>? Subnets { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }


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

    } // class AwsExocomputeConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types