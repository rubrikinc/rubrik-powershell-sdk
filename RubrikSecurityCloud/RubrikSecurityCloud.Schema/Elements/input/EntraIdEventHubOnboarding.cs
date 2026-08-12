// EntraIdEventHubOnboarding.cs
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
    #region EntraIdEventHubOnboarding

    public class EntraIdEventHubOnboarding: IInput
    {
        #region members

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("regions")]
        public List<AzureCloudAccountRegion>? Regions { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> List<TagInput>? ResourceGroupTags
        // GraphQL -> resourceGroupTags: [TagInput!] (input)
        [JsonProperty("resourceGroupTags")]
        public List<TagInput>? ResourceGroupTags { get; set; }

        //      C# -> List<TagInput>? EventHubTags
        // GraphQL -> eventHubTags: [TagInput!] (input)
        [JsonProperty("eventHubTags")]
        public List<TagInput>? EventHubTags { get; set; }

        //      C# -> AzureCloudAccountRegion? ResourceGroupRegion
        // GraphQL -> resourceGroupRegion: AzureCloudAccountRegion (enum)
        [JsonProperty("resourceGroupRegion")]
        public AzureCloudAccountRegion? ResourceGroupRegion { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }


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

    } // class EntraIdEventHubOnboarding
    #endregion

} // namespace RubrikSecurityCloud.Types