// UpdateCdmUserInfoInput.cs
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
    #region UpdateCdmUserInfoInput

    public class UpdateCdmUserInfoInput: IInput
    {
        #region members

        //      C# -> System.String? SshKey
        // GraphQL -> sshKey: String (scalar)
        [JsonProperty("sshKey")]
        public System.String? SshKey { get; set; }

        //      C# -> System.String? LastName
        // GraphQL -> lastName: String (scalar)
        [JsonProperty("lastName")]
        public System.String? LastName { get; set; }

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String (scalar)
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }

        //      C# -> System.String? MfaServerId
        // GraphQL -> mfaServerId: String (scalar)
        [JsonProperty("mfaServerId")]
        public System.String? MfaServerId { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean (scalar)
        [JsonProperty("isTotpEnforced")]
        public System.Boolean? IsTotpEnforced { get; set; }

        //      C# -> System.String? ContactNumber
        // GraphQL -> contactNumber: String (scalar)
        [JsonProperty("contactNumber")]
        public System.String? ContactNumber { get; set; }

        //      C# -> System.String? EmailAddress
        // GraphQL -> emailAddress: String (scalar)
        [JsonProperty("emailAddress")]
        public System.String? EmailAddress { get; set; }


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

    } // class UpdateCdmUserInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types