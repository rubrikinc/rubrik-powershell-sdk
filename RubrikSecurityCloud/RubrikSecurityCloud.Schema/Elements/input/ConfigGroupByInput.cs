// ConfigGroupByInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ConfigGroupByInput

    public class ConfigGroupByInput: IInput
    {
        #region members

        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("groupById")]
        public System.String? GroupById { get; set; }

        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("aggregations")]
        public List<System.String>? Aggregations { get; set; }


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

    } // class ConfigGroupByInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types