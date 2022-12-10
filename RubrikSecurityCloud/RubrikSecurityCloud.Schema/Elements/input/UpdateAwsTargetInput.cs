// UpdateAwsTargetInput.cs
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
    #region UpdateAwsTargetInput

    public class UpdateAwsTargetInput
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass (enum)
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> ProxySettingsInput? ProxySettings
        // GraphQL -> proxySettings: ProxySettingsInput (input)
        [JsonProperty("proxySettings")]
        public ProxySettingsInput? ProxySettings { get; set; }

        //      C# -> System.String? AwsComputeSettingsId
        // GraphQL -> awsComputeSettingsId: String (scalar)
        [JsonProperty("awsComputeSettingsId")]
        public System.String? AwsComputeSettingsId { get; set; }

        //      C# -> AwsCloudComputeSettingsInput? CloudComputeSettings
        // GraphQL -> cloudComputeSettings: AwsCloudComputeSettingsInput (input)
        [JsonProperty("cloudComputeSettings")]
        public AwsCloudComputeSettingsInput? CloudComputeSettings { get; set; }

        //      C# -> ProxySettingsInput? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettingsInput (input)
        [JsonProperty("computeProxySettings")]
        public ProxySettingsInput? ComputeProxySettings { get; set; }

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier (enum)
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }

        //      C# -> AwsImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: AwsImmutabilitySettings (input)
        [JsonProperty("immutabilitySettings")]
        public AwsImmutabilitySettings? ImmutabilitySettings { get; set; }

        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String (scalar)
        [JsonProperty("s3Endpoint")]
        public System.String? S3Endpoint { get; set; }

        //      C# -> System.String? KmsEndpoint
        // GraphQL -> kmsEndpoint: String (scalar)
        [JsonProperty("kmsEndpoint")]
        public System.String? KmsEndpoint { get; set; }

        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean (scalar)
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

    } // class UpdateAwsTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types