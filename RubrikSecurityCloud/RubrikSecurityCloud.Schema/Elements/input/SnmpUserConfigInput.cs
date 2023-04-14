// SnmpUserConfigInput.cs
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
    #region SnmpUserConfigInput

    public class SnmpUserConfigInput: IInput
    {
        #region members

        //      C# -> System.String? AuthPassword
        // GraphQL -> authPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("authPassword")]
        public System.String? AuthPassword { get; set; }

        //      C# -> System.String? PrivPassword
        // GraphQL -> privPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("privPassword")]
        public System.String? PrivPassword { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
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

    } // class SnmpUserConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types