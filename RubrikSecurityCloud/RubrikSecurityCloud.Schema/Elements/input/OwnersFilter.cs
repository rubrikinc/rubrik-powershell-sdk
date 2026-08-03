// OwnersFilter.cs
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
    #region OwnersFilter

    public class OwnersFilter: IInput
    {
        #region members

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<IdpType>? IdpTypesFilter
        // GraphQL -> idpTypesFilter: [IdpType!] (enum)
        [JsonProperty("idpTypesFilter")]
        public List<IdpType>? IdpTypesFilter { get; set; }

        //      C# -> List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes
        // GraphQL -> principalTypes: [PrincipalRiskySummaryPrincipalType!] (enum)
        [JsonProperty("principalTypes")]
        public List<PrincipalRiskySummaryPrincipalType>? PrincipalTypes { get; set; }

        //      C# -> System.String? TimelineDate
        // GraphQL -> timelineDate: String (scalar)
        [JsonProperty("timelineDate")]
        public System.String? TimelineDate { get; set; }


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

    } // class OwnersFilter
    #endregion

} // namespace RubrikSecurityCloud.Types