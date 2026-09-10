// RegistryPatternSpecInputType.cs
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
    #region RegistryPatternSpecInputType

    public class RegistryPatternSpecInputType: IInput
    {
        #region members

        //      C# -> System.String? KeyPattern
        // GraphQL -> keyPattern: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("keyPattern")]
        public System.String? KeyPattern { get; set; }

        //      C# -> List<System.String>? ValueNames
        // GraphQL -> valueNames: [String!] (scalar)
        [JsonProperty("valueNames")]
        public List<System.String>? ValueNames { get; set; }

        //      C# -> List<System.String>? ValueTypes
        // GraphQL -> valueTypes: [String!] (scalar)
        [JsonProperty("valueTypes")]
        public List<System.String>? ValueTypes { get; set; }

        //      C# -> System.String? ValueDataEq
        // GraphQL -> valueDataEq: String (scalar)
        [JsonProperty("valueDataEq")]
        public System.String? ValueDataEq { get; set; }

        //      C# -> System.String? ValueDataNotEq
        // GraphQL -> valueDataNotEq: String (scalar)
        [JsonProperty("valueDataNotEq")]
        public System.String? ValueDataNotEq { get; set; }

        //      C# -> System.String? ValueDataContains
        // GraphQL -> valueDataContains: String (scalar)
        [JsonProperty("valueDataContains")]
        public System.String? ValueDataContains { get; set; }

        //      C# -> System.String? ValueDataNotContains
        // GraphQL -> valueDataNotContains: String (scalar)
        [JsonProperty("valueDataNotContains")]
        public System.String? ValueDataNotContains { get; set; }


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

    } // class RegistryPatternSpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types