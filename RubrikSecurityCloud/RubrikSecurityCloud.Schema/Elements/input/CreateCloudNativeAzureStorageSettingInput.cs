// CreateCloudNativeAzureStorageSettingInput.cs
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
    #region CreateCloudNativeAzureStorageSettingInput

    public class CreateCloudNativeAzureStorageSettingInput: IInput
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

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("containerName")]
        public System.String? ContainerName { get; set; }

        //      C# -> TagsInput? StorageAccountTags
        // GraphQL -> storageAccountTags: TagsInput (input)
        [JsonProperty("storageAccountTags")]
        public TagsInput? StorageAccountTags { get; set; }

        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion (enum)
        [JsonProperty("storageAccountRegion")]
        public AzureRegion? StorageAccountRegion { get; set; }

        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageTier")]
        public AzureStorageTier? StorageTier { get; set; }

        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("redundancy")]
        public AzureRedundancy? Redundancy { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> List<AzureCmkInput>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmkInput!] (input)
        [JsonProperty("cmkInfo")]
        public List<AzureCmkInput>? CmkInfo { get; set; }

        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType (enum)
        [JsonProperty("azureCloudType")]
        public AzureCloudType? AzureCloudType { get; set; }


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

    } // class CreateCloudNativeAzureStorageSettingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types