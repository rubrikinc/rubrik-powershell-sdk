// TestWebhookInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TestWebhookInput

    public class TestWebhookInput
    {
        #region members
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }

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

        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("url")]
        public System.String? Url { get; set; }

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

    } // class TestWebhookInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types