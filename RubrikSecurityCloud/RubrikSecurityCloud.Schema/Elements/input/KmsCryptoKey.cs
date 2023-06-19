// KmsCryptoKey.cs
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
    #region KmsCryptoKey

    public class KmsCryptoKey: IInput
    {
        #region members

        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String (scalar)
        [JsonProperty("projectNativeId")]
        public System.String? ProjectNativeId { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String (scalar)
        [JsonProperty("keyRing")]
        public System.String? KeyRing { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }


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

    } // class KmsCryptoKey
    #endregion

} // namespace RubrikSecurityCloud.Types