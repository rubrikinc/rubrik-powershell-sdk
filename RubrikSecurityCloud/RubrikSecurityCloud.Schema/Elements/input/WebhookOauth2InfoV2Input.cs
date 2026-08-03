// WebhookOauth2InfoV2Input.cs
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
    #region WebhookOauth2InfoV2Input

    public class WebhookOauth2InfoV2Input: IInput
    {
        #region members

        //      C# -> WebhookOauth2GrantTypeV2? GrantType
        // GraphQL -> grantType: WebhookOauth2GrantTypeV2! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("grantType")]
        public WebhookOauth2GrantTypeV2? GrantType { get; set; }

        //      C# -> System.String? TokenUrl
        // GraphQL -> tokenUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tokenUrl")]
        public System.String? TokenUrl { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }

        //      C# -> System.String? Audience
        // GraphQL -> audience: String (scalar)
        [JsonProperty("audience")]
        public System.String? Audience { get; set; }

        //      C# -> System.String? Resource
        // GraphQL -> resource: String (scalar)
        [JsonProperty("resource")]
        public System.String? Resource { get; set; }

        //      C# -> WebhookOauth2ClientAuthMethodV2? ClientAuthMethod
        // GraphQL -> clientAuthMethod: WebhookOauth2ClientAuthMethodV2 (enum)
        [JsonProperty("clientAuthMethod")]
        public WebhookOauth2ClientAuthMethodV2? ClientAuthMethod { get; set; }


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

    } // class WebhookOauth2InfoV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types