// CloudDirectCheckSharePathReq.cs
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
    #region CloudDirectCheckSharePathReq

    public class CloudDirectCheckSharePathReq: IInput
    {
        #region members

        //      C# -> CloudDirectCheckShareProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectCheckShareProtocolType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("protocol")]
        public CloudDirectCheckShareProtocolType? Protocol { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? User
        // GraphQL -> user: String (scalar)
        [JsonProperty("user")]
        public System.String? User { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }


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

    } // class CloudDirectCheckSharePathReq
    #endregion

} // namespace RubrikSecurityCloud.Types