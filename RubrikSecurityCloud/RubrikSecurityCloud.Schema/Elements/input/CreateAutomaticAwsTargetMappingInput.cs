// CreateAutomaticAwsTargetMappingInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateAutomaticAwsTargetMappingInput

    public class CreateAutomaticAwsTargetMappingInput: IInput
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

        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketPrefix")]
        public System.String? BucketPrefix { get; set; }

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

        //      C# -> List<System.String>? ClusterUuidList
        // GraphQL -> clusterUuidList: [String!] (scalar)
        [JsonProperty("clusterUuidList")]
        public List<System.String>? ClusterUuidList { get; set; }

        //      C# -> System.String? AwsComputeSettingsId
        // GraphQL -> awsComputeSettingsId: String (scalar)
        [JsonProperty("awsComputeSettingsId")]
        public System.String? AwsComputeSettingsId { get; set; }


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

    } // class CreateAutomaticAwsTargetMappingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types