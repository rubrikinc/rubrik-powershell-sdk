// KdcConfigInput.cs
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
    #region KdcConfigInput

    public class KdcConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Realm
        // GraphQL -> realm: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("realm")]
        public System.String? Realm { get; set; }

        //      C# -> System.String? Kdc1
        // GraphQL -> kdc1: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("kdc1")]
        public System.String? Kdc1 { get; set; }

        //      C# -> System.String? Kdc2
        // GraphQL -> kdc2: String (scalar)
        [JsonProperty("kdc2")]
        public System.String? Kdc2 { get; set; }


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

    } // class KdcConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types