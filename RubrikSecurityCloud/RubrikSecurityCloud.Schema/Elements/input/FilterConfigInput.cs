// FilterConfigInput.cs
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
    #region FilterConfigInput

    public class FilterConfigInput: IInput
    {
        #region members

        //      C# -> FilterType? FilterType
        // GraphQL -> filterType: FilterType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("filterType")]
        public FilterType? FilterType { get; set; }

        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("values")]
        public List<System.String>? Values { get; set; }

        //      C# -> Relationship? Relationship
        // GraphQL -> relationship: Relationship! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("relationship")]
        public Relationship? Relationship { get; set; }


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

    } // class FilterConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types