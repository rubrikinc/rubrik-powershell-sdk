// ContactsSearchFilter.cs
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
    #region ContactsSearchFilter

    public class ContactsSearchFilter: IInput
    {
        #region members

        //      C# -> ContactsSearchKeywordFilter? SearchKeywordFilter
        // GraphQL -> searchKeywordFilter: ContactsSearchKeywordFilter (input)
        [JsonProperty("searchKeywordFilter")]
        public ContactsSearchKeywordFilter? SearchKeywordFilter { get; set; }

        //      C# -> ContactsSearchObjectFilter? SearchObjectFilter
        // GraphQL -> searchObjectFilter: ContactsSearchObjectFilter (input)
        [JsonProperty("searchObjectFilter")]
        public ContactsSearchObjectFilter? SearchObjectFilter { get; set; }

        //      C# -> LambdaPathFilters? LambdaFilters
        // GraphQL -> lambdaFilters: LambdaPathFilters (input)
        [JsonProperty("lambdaFilters")]
        public LambdaPathFilters? LambdaFilters { get; set; }

        //      C# -> System.Boolean? SkipRifItems
        // GraphQL -> skipRifItems: Boolean (scalar)
        [JsonProperty("skipRifItems")]
        public System.Boolean? SkipRifItems { get; set; }


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

    } // class ContactsSearchFilter
    #endregion

} // namespace RubrikSecurityCloud.Types