// CustomResourceDependencyInput.cs
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
    #region CustomResourceDependencyInput

    public class CustomResourceDependencyInput: IInput
    {
        #region members

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("group")]
        public System.String? Group { get; set; }

        //      C# -> System.String? SelectionMode
        // GraphQL -> selectionMode: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("selectionMode")]
        public System.String? SelectionMode { get; set; }

        //      C# -> System.String? Resource
        // GraphQL -> resource: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resource")]
        public System.String? Resource { get; set; }


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

    } // class CustomResourceDependencyInput
    #endregion

} // namespace RubrikSecurityCloud.Types