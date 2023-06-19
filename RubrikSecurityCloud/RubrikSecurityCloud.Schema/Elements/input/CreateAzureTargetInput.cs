// CreateAzureTargetInput.cs
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
    #region CreateAzureTargetInput

    public class CreateAzureTargetInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

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

        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("containerName")]
        public System.String? ContainerName { get; set; }

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

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> AzureImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: AzureImmutabilitySettings (input)
        [JsonProperty("immutabilitySettings")]
        public AzureImmutabilitySettings? ImmutabilitySettings { get; set; }

        //      C# -> AzureRetrievalTier? RetrievalTier
        // GraphQL -> retrievalTier: AzureRetrievalTier (enum)
        [JsonProperty("retrievalTier")]
        public AzureRetrievalTier? RetrievalTier { get; set; }

        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bypassProxy")]
        public System.Boolean? BypassProxy { get; set; }


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

    } // class CreateAzureTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types