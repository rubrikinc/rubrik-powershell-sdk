// KmsCryptoKey.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region KmsCryptoKey

    public class KmsCryptoKey
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

} // namespace Rubrik.SecurityCloud.Types