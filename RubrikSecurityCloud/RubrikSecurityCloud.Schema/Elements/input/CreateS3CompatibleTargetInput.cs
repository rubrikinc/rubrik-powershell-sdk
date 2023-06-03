// CreateS3CompatibleTargetInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateS3CompatibleTargetInput

    public class CreateS3CompatibleTargetInput: IInput
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

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("endpoint")]
        public System.String? Endpoint { get; set; }

        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketPrefix")]
        public System.String? BucketPrefix { get; set; }

        //      C# -> System.Int32? NumberOfBuckets
        // GraphQL -> numberOfBuckets: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("numberOfBuckets")]
        public System.Int32? NumberOfBuckets { get; set; }

        //      C# -> System.String? EncryptionKeyInDer
        // GraphQL -> encryptionKeyInDer: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionKeyInDer")]
        public System.String? EncryptionKeyInDer { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.Boolean? UseSystemProxy
        // GraphQL -> useSystemProxy: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("useSystemProxy")]
        public System.Boolean? UseSystemProxy { get; set; }

        //      C# -> S3CompatibleSubType? SubType
        // GraphQL -> subType: S3CompatibleSubType (enum)
        [JsonProperty("subType")]
        public S3CompatibleSubType? SubType { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> LocationImmutabilitySettings? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: LocationImmutabilitySettings (input)
        [JsonProperty("immutabilitySettings")]
        public LocationImmutabilitySettings? ImmutabilitySettings { get; set; }

        //      C# -> IbmCosDetails? IbmDetails
        // GraphQL -> ibmDetails: IbmCosDetails (input)
        [JsonProperty("ibmDetails")]
        public IbmCosDetails? IbmDetails { get; set; }


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

    } // class CreateS3CompatibleTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types