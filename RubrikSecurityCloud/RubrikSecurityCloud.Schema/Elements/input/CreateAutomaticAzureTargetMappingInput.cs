// CreateAutomaticAzureTargetMappingInput.cs
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
    #region CreateAutomaticAzureTargetMappingInput

    public class CreateAutomaticAzureTargetMappingInput
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("containerNamePrefix")]
        public System.String? ContainerNamePrefix { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceType")]
        public InstanceTypeEnum? InstanceType { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }

        //      C# -> AzureCloudComputeSettingsInput? ComputeSettings
        // GraphQL -> computeSettings: AzureCloudComputeSettingsInput (input)
        [JsonProperty("computeSettings")]
        public AzureCloudComputeSettingsInput? ComputeSettings { get; set; }

        //      C# -> ProxySettingsInput? ProxySettings
        // GraphQL -> proxySettings: ProxySettingsInput (input)
        [JsonProperty("proxySettings")]
        public ProxySettingsInput? ProxySettings { get; set; }

        //      C# -> List<System.String>? ClusterUuidList
        // GraphQL -> clusterUuidList: [String!] (scalar)
        [JsonProperty("clusterUuidList")]
        public List<System.String>? ClusterUuidList { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

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

    } // class CreateAutomaticAzureTargetMappingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types