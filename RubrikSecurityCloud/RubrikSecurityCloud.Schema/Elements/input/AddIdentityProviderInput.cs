// AddIdentityProviderInput.cs
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
    #region AddIdentityProviderInput

    public class AddIdentityProviderInput: IInput
    {
        #region members

        //      C# -> List<IdpClaimAttribute>? IdpClaimAttributes
        // GraphQL -> idpClaimAttributes: [IdpClaimAttribute!] (input)
        [JsonProperty("idpClaimAttributes")]
        public List<IdpClaimAttribute>? IdpClaimAttributes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }

        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("signingCertificate")]
        public System.String? SigningCertificate { get; set; }

        //      C# -> System.Boolean? IsTemp
        // GraphQL -> isTemp: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isTemp")]
        public System.Boolean? IsTemp { get; set; }


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

    } // class AddIdentityProviderInput
    #endregion

} // namespace RubrikSecurityCloud.Types