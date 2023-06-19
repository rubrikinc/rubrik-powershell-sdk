// CreateAwsReaderTargetInput.cs
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
    #region CreateAwsReaderTargetInput

    public class CreateAwsReaderTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String (scalar)
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
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

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier (enum)
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }

        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String (scalar)
        [JsonProperty("s3Endpoint")]
        public System.String? S3Endpoint { get; set; }

        //      C# -> System.String? KmsEndpoint
        // GraphQL -> kmsEndpoint: String (scalar)
        [JsonProperty("kmsEndpoint")]
        public System.String? KmsEndpoint { get; set; }

        //      C# -> ProxySettingsInput? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettingsInput (input)
        [JsonProperty("computeProxySettings")]
        public ProxySettingsInput? ComputeProxySettings { get; set; }

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

    } // class CreateAwsReaderTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types