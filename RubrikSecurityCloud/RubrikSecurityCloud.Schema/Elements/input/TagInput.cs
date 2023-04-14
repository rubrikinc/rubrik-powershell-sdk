// TagInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TagInput

    public class TagInput: IInput
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("value")]
        public System.String? Value { get; set; }


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

    } // class TagInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types