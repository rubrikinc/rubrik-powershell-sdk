// AzureVmConfig.cs
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
    #region AzureVmConfig

    public class AzureVmConfig: IInput
    {
        #region members

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int32? NodeSizeGb
        // GraphQL -> nodeSizeGb: Int (scalar)
        [JsonProperty("nodeSizeGb")]
        public System.Int32? NodeSizeGb { get; set; }

        //      C# -> System.String? NetworkResourceGroup
        // GraphQL -> networkResourceGroup: String (scalar)
        [JsonProperty("networkResourceGroup")]
        public System.String? NetworkResourceGroup { get; set; }

        //      C# -> System.String? VnetResourceGroup
        // GraphQL -> vnetResourceGroup: String (scalar)
        [JsonProperty("vnetResourceGroup")]
        public System.String? VnetResourceGroup { get; set; }

        //      C# -> System.String? NetworkSecurityGroup
        // GraphQL -> networkSecurityGroup: String (scalar)
        [JsonProperty("networkSecurityGroup")]
        public System.String? NetworkSecurityGroup { get; set; }

        //      C# -> System.String? NetworkSecurityResourceGroup
        // GraphQL -> networkSecurityResourceGroup: String (scalar)
        [JsonProperty("networkSecurityResourceGroup")]
        public System.String? NetworkSecurityResourceGroup { get; set; }

        //      C# -> System.String? Vnet
        // GraphQL -> vnet: String (scalar)
        [JsonProperty("vnet")]
        public System.String? Vnet { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> System.String? Tags
        // GraphQL -> tags: String (scalar)
        [JsonProperty("tags")]
        public System.String? Tags { get; set; }

        //      C# -> System.String? VmImage
        // GraphQL -> vmImage: String (scalar)
        [JsonProperty("vmImage")]
        public System.String? VmImage { get; set; }

        //      C# -> System.String? CdmProduct
        // GraphQL -> cdmProduct: String (scalar)
        [JsonProperty("cdmProduct")]
        public System.String? CdmProduct { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType (enum)
        [JsonProperty("vmType")]
        public VmType? VmType { get; set; }

        //      C# -> AzureInstanceType? InstanceType
        // GraphQL -> instanceType: AzureInstanceType (enum)
        [JsonProperty("instanceType")]
        public AzureInstanceType? InstanceType { get; set; }


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

    } // class AzureVmConfig
    #endregion

} // namespace RubrikSecurityCloud.Types