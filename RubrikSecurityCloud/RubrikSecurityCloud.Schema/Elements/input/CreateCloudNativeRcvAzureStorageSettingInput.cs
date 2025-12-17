// CreateCloudNativeRcvAzureStorageSettingInput.cs
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
    #region CreateCloudNativeRcvAzureStorageSettingInput

    public class CreateCloudNativeRcvAzureStorageSettingInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }

        //      C# -> RcsRegionEnumType? RcvRegion
        // GraphQL -> rcvRegion: RcsRegionEnumType (enum)
        [JsonProperty("rcvRegion")]
        public RcsRegionEnumType? RcvRegion { get; set; }

        //      C# -> AzureStorageTier? Tier
        // GraphQL -> tier: AzureStorageTier (enum)
        [JsonProperty("tier")]
        public AzureStorageTier? Tier { get; set; }

        //      C# -> RcsTierEnumType? RcvTier
        // GraphQL -> rcvTier: RcsTierEnumType (enum)
        [JsonProperty("rcvTier")]
        public RcsTierEnumType? RcvTier { get; set; }

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String (scalar)
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }


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

    } // class CreateCloudNativeRcvAzureStorageSettingInput
    #endregion

} // namespace RubrikSecurityCloud.Types