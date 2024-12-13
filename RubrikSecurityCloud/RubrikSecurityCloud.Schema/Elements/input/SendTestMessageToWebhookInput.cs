// SendTestMessageToWebhookInput.cs
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
    #region SendTestMessageToWebhookInput

    public class SendTestMessageToWebhookInput: IInput
    {
        #region members

        //      C# -> System.String? Url
        // GraphQL -> url: String (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> ProviderTypeV2? ProviderType
        // GraphQL -> providerType: ProviderTypeV2! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("providerType")]
        public ProviderTypeV2? ProviderType { get; set; }

        //      C# -> WebhookAuthInfoV2Input? AuthInfo
        // GraphQL -> authInfo: WebhookAuthInfoV2Input! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("authInfo")]
        public WebhookAuthInfoV2Input? AuthInfo { get; set; }

        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }


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

    } // class SendTestMessageToWebhookInput
    #endregion

} // namespace RubrikSecurityCloud.Types