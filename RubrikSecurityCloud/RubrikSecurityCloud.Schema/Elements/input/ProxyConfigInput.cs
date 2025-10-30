// ProxyConfigInput.cs
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
    #region ProxyConfigInput

    public class ProxyConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("protocol")]
        public System.String? Protocol { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


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

    } // class ProxyConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types