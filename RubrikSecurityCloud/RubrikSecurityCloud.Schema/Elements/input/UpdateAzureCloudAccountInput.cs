// UpdateAzureCloudAccountInput.cs
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
    #region UpdateAzureCloudAccountInput

    public class UpdateAzureCloudAccountInput: IInput
    {
        #region members

        //      C# -> List<AzureCloudAccountSubscriptionInput>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscriptionInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptions")]
        public List<AzureCloudAccountSubscriptionInput>? Subscriptions { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> List<AzureCloudAccountRegion>? RegionsToAdd
        // GraphQL -> regionsToAdd: [AzureCloudAccountRegion!] (enum)
        [JsonProperty("regionsToAdd")]
        public List<AzureCloudAccountRegion>? RegionsToAdd { get; set; }

        //      C# -> List<AzureCloudAccountRegion>? RegionsToRemove
        // GraphQL -> regionsToRemove: [AzureCloudAccountRegion!] (enum)
        [JsonProperty("regionsToRemove")]
        public List<AzureCloudAccountRegion>? RegionsToRemove { get; set; }


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

    } // class UpdateAzureCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types