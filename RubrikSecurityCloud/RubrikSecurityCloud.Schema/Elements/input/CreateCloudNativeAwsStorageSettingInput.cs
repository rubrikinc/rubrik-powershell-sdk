// CreateCloudNativeAwsStorageSettingInput.cs
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
    #region CreateCloudNativeAwsStorageSettingInput

    public class CreateCloudNativeAwsStorageSettingInput: IInput
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
        // GraphQL -> region: AwsRegion (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> TagsInput? BucketTags
        // GraphQL -> bucketTags: TagsInput (input)
        [JsonProperty("bucketTags")]
        public TagsInput? BucketTags { get; set; }


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

    } // class CreateCloudNativeAwsStorageSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types