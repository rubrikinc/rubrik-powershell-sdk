// ModifyIdentityProviderInput.cs
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
    #region ModifyIdentityProviderInput

    public class ModifyIdentityProviderInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String (scalar)
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }

        //      C# -> System.String? SigningCertificate
        // GraphQL -> signingCertificate: String (scalar)
        [JsonProperty("signingCertificate")]
        public System.String? SigningCertificate { get; set; }

        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean (scalar)
        [JsonProperty("isDefault")]
        public System.Boolean? IsDefault { get; set; }

        //      C# -> List<IdpClaimAttribute>? IdpClaimAttributes
        // GraphQL -> idpClaimAttributes: [IdpClaimAttribute!] (input)
        [JsonProperty("idpClaimAttributes")]
        public List<IdpClaimAttribute>? IdpClaimAttributes { get; set; }

        //      C# -> System.String? IdpId
        // GraphQL -> idpId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("idpId")]
        public System.String? IdpId { get; set; }


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

    } // class ModifyIdentityProviderInput
    #endregion

} // namespace RubrikSecurityCloud.Types