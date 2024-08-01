// CreateS3BucketInput.cs
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
    #region CreateS3BucketInput

    public class CreateS3BucketInput: IInput
    {
        #region members

        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsNativeAccountId")]
        public System.String? AwsNativeAccountId { get; set; }

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> BucketOwnershipControls? BucketOwnershipControl
        // GraphQL -> bucketOwnershipControl: BucketOwnershipControls! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("bucketOwnershipControl")]
        public BucketOwnershipControls? BucketOwnershipControl { get; set; }

        //      C# -> List<S3Tag>? Tags
        // GraphQL -> tags: [S3Tag!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("tags")]
        public List<S3Tag>? Tags { get; set; }

        //      C# -> System.Boolean? VersioningEnabled
        // GraphQL -> versioningEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("versioningEnabled")]
        public System.Boolean? VersioningEnabled { get; set; }


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

    } // class CreateS3BucketInput
    #endregion

} // namespace RubrikSecurityCloud.Types