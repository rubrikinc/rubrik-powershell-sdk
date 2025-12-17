// StartRecoverAzureNativeStorageAccountJobInput.cs
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
    #region StartRecoverAzureNativeStorageAccountJobInput

    public class StartRecoverAzureNativeStorageAccountJobInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? DestinationSubscriptionRubrikId
        // GraphQL -> destinationSubscriptionRubrikId: UUID (scalar)
        [JsonProperty("destinationSubscriptionRubrikId")]
        public System.String? DestinationSubscriptionRubrikId { get; set; }

        //      C# -> System.Boolean? ShouldExportTags
        // GraphQL -> shouldExportTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldExportTags")]
        public System.Boolean? ShouldExportTags { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion (enum)
        [JsonProperty("region")]
        public AzureNativeRegion? Region { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> List<System.String>? ObjectKeys
        // GraphQL -> objectKeys: [String!] (scalar)
        [JsonProperty("objectKeys")]
        public List<System.String>? ObjectKeys { get; set; }

        //      C# -> AzureStorageAccessTier? Tier
        // GraphQL -> tier: AzureStorageAccessTier! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("tier")]
        public AzureStorageAccessTier? Tier { get; set; }


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

    } // class StartRecoverAzureNativeStorageAccountJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types