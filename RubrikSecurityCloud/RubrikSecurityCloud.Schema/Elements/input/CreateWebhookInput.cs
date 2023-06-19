// CreateWebhookInput.cs
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
    #region CreateWebhookInput

    public class CreateWebhookInput: IInput
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> SubscriptionTypeInput? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionTypeInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionType")]
        public SubscriptionTypeInput? SubscriptionType { get; set; }

        //      C# -> SubscriptionSeverityInput? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverityInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionSeverity")]
        public SubscriptionSeverityInput? SubscriptionSeverity { get; set; }

        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("providerType")]
        public ProviderType? ProviderType { get; set; }

        //      C# -> AuthInfoInput? AuthInfo
        // GraphQL -> authInfo: AuthInfoInput (input)
        [JsonProperty("authInfo")]
        public AuthInfoInput? AuthInfo { get; set; }


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

    } // class CreateWebhookInput
    #endregion

} // namespace RubrikSecurityCloud.Types