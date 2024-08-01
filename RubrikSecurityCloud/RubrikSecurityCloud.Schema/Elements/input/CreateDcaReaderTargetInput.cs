// CreateDcaReaderTargetInput.cs
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
    #region CreateDcaReaderTargetInput

    public class CreateDcaReaderTargetInput: IInput
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

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("s3Endpoint")]
        public System.String? S3Endpoint { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> AwsDcaRegion? Region
        // GraphQL -> region: AwsDcaRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AwsDcaRegion? Region { get; set; }

        //      C# -> System.String? CertificateContent
        // GraphQL -> certificateContent: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("certificateContent")]
        public System.String? CertificateContent { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> System.String? Mission
        // GraphQL -> mission: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mission")]
        public System.String? Mission { get; set; }

        //      C# -> System.Int32? TokenDuration
        // GraphQL -> tokenDuration: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tokenDuration")]
        public System.Int32? TokenDuration { get; set; }

        //      C# -> System.String? CapEndPoint
        // GraphQL -> capEndPoint: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("capEndPoint")]
        public System.String? CapEndPoint { get; set; }

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }


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

    } // class CreateDcaReaderTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types