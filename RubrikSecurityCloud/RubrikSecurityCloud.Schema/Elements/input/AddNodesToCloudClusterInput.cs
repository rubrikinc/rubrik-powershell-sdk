// AddNodesToCloudClusterInput.cs
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
    #region AddNodesToCloudClusterInput

    public class AddNodesToCloudClusterInput: IInput
    {
        #region members

        //      C# -> System.Int32? NumberOfNodes
        // GraphQL -> numberOfNodes: Int (scalar)
        [JsonProperty("numberOfNodes")]
        public System.Int32? NumberOfNodes { get; set; }

        //      C# -> System.String? AwsImageId
        // GraphQL -> awsImageId: String (scalar)
        [JsonProperty("awsImageId")]
        public System.String? AwsImageId { get; set; }

        //      C# -> System.String? AzureImageName
        // GraphQL -> azureImageName: String (scalar)
        [JsonProperty("azureImageName")]
        public System.String? AzureImageName { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? ShouldKeepResourcesOnFailure
        // GraphQL -> shouldKeepResourcesOnFailure: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldKeepResourcesOnFailure")]
        public System.Boolean? ShouldKeepResourcesOnFailure { get; set; }


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

    } // class AddNodesToCloudClusterInput
    #endregion

} // namespace RubrikSecurityCloud.Types