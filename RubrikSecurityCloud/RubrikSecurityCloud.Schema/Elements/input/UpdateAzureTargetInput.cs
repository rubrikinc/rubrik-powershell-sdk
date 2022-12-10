// UpdateAzureTargetInput.cs
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
    #region UpdateAzureTargetInput

    public class UpdateAzureTargetInput
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String (scalar)
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> AzureCloudComputeSettingsInput? ComputeSettings
        // GraphQL -> computeSettings: AzureCloudComputeSettingsInput (input)
        [JsonProperty("computeSettings")]
        public AzureCloudComputeSettingsInput? ComputeSettings { get; set; }

        //      C# -> ProxySettingsInput? ProxySettings
        // GraphQL -> proxySettings: ProxySettingsInput (input)
        [JsonProperty("proxySettings")]
        public ProxySettingsInput? ProxySettings { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean (scalar)
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

    } // class UpdateAzureTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types