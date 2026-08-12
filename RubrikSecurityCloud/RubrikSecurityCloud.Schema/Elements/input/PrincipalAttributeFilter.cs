// PrincipalAttributeFilter.cs
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
    #region PrincipalAttributeFilter

    public class PrincipalAttributeFilter: IInput
    {
        #region members

        //      C# -> List<IdpType>? IdpTypes
        // GraphQL -> idpTypes: [IdpType!] (enum)
        [JsonProperty("idpTypes")]
        public List<IdpType>? IdpTypes { get; set; }

        //      C# -> List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes
        // GraphQL -> principalTypes: [PrincipalRiskySummaryPrincipalType!] (enum)
        [JsonProperty("principalTypes")]
        public List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes { get; set; }

        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!] (scalar)
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> System.Boolean? ShouldIncludeDeleted
        // GraphQL -> shouldIncludeDeleted: Boolean (scalar)
        [JsonProperty("shouldIncludeDeleted")]
        public System.Boolean? ShouldIncludeDeleted { get; set; }


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

    } // class PrincipalAttributeFilter
    #endregion

} // namespace RubrikSecurityCloud.Types