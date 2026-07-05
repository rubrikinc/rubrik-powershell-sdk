// PrincipalMetadataFiltersInput.cs
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
    #region PrincipalMetadataFiltersInput

    public class PrincipalMetadataFiltersInput: IInput
    {
        #region members

        //      C# -> List<ViolationPrincipalType>? PrincipalTypes
        // GraphQL -> principalTypes: [ViolationPrincipalType!] (enum)
        [JsonProperty("principalTypes")]
        public List<ViolationPrincipalType>? PrincipalTypes { get; set; }

        //      C# -> List<PrincipalOrigin>? IdentityOrigins
        // GraphQL -> identityOrigins: [PrincipalOrigin!] (enum)
        [JsonProperty("identityOrigins")]
        public List<PrincipalOrigin>? IdentityOrigins { get; set; }

        //      C# -> List<IdpType>? IdpTypes
        // GraphQL -> idpTypes: [IdpType!] (enum)
        [JsonProperty("idpTypes")]
        public List<IdpType>? IdpTypes { get; set; }

        //      C# -> List<System.String>? Sources
        // GraphQL -> sources: [String!] (scalar)
        [JsonProperty("sources")]
        public List<System.String>? Sources { get; set; }

        //      C# -> System.String? IdentityNameSearch
        // GraphQL -> identityNameSearch: String (scalar)
        [JsonProperty("identityNameSearch")]
        public System.String? IdentityNameSearch { get; set; }


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

    } // class PrincipalMetadataFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types