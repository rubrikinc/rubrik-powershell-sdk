// AzureCloudComputeSettingsInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureCloudComputeSettingsInput

    public class AzureCloudComputeSettingsInput
    {
        #region members
        //      C# -> System.String? AppId
        // GraphQL -> appId: String (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecretKey
        // GraphQL -> appSecretKey: String (scalar)
        [JsonProperty("appSecretKey")]
        public System.String? AppSecretKey { get; set; }

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion (enum)
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }

        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String (scalar)
        [JsonProperty("generalPurposeStorageName")]
        public System.String? GeneralPurposeStorageName { get; set; }

        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String (scalar)
        [JsonProperty("generalPurposeStorageContainer")]
        public System.String? GeneralPurposeStorageContainer { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String (scalar)
        [JsonProperty("virtualNetworkId")]
        public System.String? VirtualNetworkId { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> ProxySettingsInput? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettingsInput (input)
        [JsonProperty("computeProxySettings")]
        public ProxySettingsInput? ComputeProxySettings { get; set; }

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

    } // class AzureCloudComputeSettingsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types