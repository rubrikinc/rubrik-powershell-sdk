// AuthInfoInput.cs
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
    #region AuthInfoInput

    public class AuthInfoInput: IInput
    {
        #region members

        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("authType")]
        public AuthenticationType? AuthType { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }

        //      C# -> UserCredentials? UserCredentials
        // GraphQL -> userCredentials: UserCredentials (input)
        [JsonProperty("userCredentials")]
        public UserCredentials? UserCredentials { get; set; }

        //      C# -> CustomHeader? CustomHeader
        // GraphQL -> customHeader: CustomHeader (input)
        [JsonProperty("customHeader")]
        public CustomHeader? CustomHeader { get; set; }


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

    } // class AuthInfoInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types