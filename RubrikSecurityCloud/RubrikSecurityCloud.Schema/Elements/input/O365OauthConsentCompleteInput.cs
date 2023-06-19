// O365OauthConsentCompleteInput.cs
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
    #region O365OauthConsentCompleteInput

    public class O365OauthConsentCompleteInput: IInput
    {
        #region members

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? StateToken
        // GraphQL -> stateToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("stateToken")]
        public System.String? StateToken { get; set; }

        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("redirectUrl")]
        public System.String? RedirectUrl { get; set; }

        //      C# -> System.String? ResourceNaturalId
        // GraphQL -> resourceNaturalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceNaturalId")]
        public System.String? ResourceNaturalId { get; set; }


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

    } // class O365OauthConsentCompleteInput
    #endregion

} // namespace RubrikSecurityCloud.Types