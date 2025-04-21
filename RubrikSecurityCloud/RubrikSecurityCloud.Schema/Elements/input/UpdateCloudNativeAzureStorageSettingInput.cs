// UpdateCloudNativeAzureStorageSettingInput.cs
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
    #region UpdateCloudNativeAzureStorageSettingInput

    public class UpdateCloudNativeAzureStorageSettingInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> TagsInput? StorageAccountTags
        // GraphQL -> storageAccountTags: TagsInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("storageAccountTags")]
        public TagsInput? StorageAccountTags { get; set; }

        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageTier")]
        public AzureStorageTier? StorageTier { get; set; }

        //      C# -> List<AzureCmkInput>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmkInput!] (input)
        [JsonProperty("cmkInfo")]
        public List<AzureCmkInput>? CmkInfo { get; set; }

        //      C# -> AzureStorageAccountNetworkAccess? NetworkAccessType
        // GraphQL -> networkAccessType: AzureStorageAccountNetworkAccess (enum)
        [JsonProperty("networkAccessType")]
        public AzureStorageAccountNetworkAccess? NetworkAccessType { get; set; }


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

    } // class UpdateCloudNativeAzureStorageSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types