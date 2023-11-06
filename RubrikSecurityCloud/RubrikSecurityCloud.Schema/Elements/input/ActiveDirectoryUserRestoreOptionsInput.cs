// ActiveDirectoryUserRestoreOptionsInput.cs
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
    #region ActiveDirectoryUserRestoreOptionsInput

    public class ActiveDirectoryUserRestoreOptionsInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldEnableUser
        // GraphQL -> shouldEnableUser: Boolean (scalar)
        [JsonProperty("shouldEnableUser")]
        public System.Boolean? ShouldEnableUser { get; set; }

        //      C# -> System.Boolean? ShouldChangePassword
        // GraphQL -> shouldChangePassword: Boolean (scalar)
        [JsonProperty("shouldChangePassword")]
        public System.Boolean? ShouldChangePassword { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> ActiveDirectoryUserPasswordRecoveryOption? PasswordOptions
        // GraphQL -> passwordOptions: ActiveDirectoryUserPasswordRecoveryOption (enum)
        [JsonProperty("passwordOptions")]
        public ActiveDirectoryUserPasswordRecoveryOption? PasswordOptions { get; set; }


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

    } // class ActiveDirectoryUserRestoreOptionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types