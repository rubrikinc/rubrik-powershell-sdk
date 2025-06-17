// PasskeyConfigInput.cs
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
    #region PasskeyConfigInput

    public class PasskeyConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? PasskeysAllowed
        // GraphQL -> passkeysAllowed: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("passkeysAllowed")]
        public System.Boolean? PasskeysAllowed { get; set; }

        //      C# -> System.Boolean? PlatformPasskeyAllowed
        // GraphQL -> platformPasskeyAllowed: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("platformPasskeyAllowed")]
        public System.Boolean? PlatformPasskeyAllowed { get; set; }

        //      C# -> System.Boolean? RoamingPasskeyAllowed
        // GraphQL -> roamingPasskeyAllowed: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("roamingPasskeyAllowed")]
        public System.Boolean? RoamingPasskeyAllowed { get; set; }

        //      C# -> System.Int32? MaxPasskeysAllowed
        // GraphQL -> maxPasskeysAllowed: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("maxPasskeysAllowed")]
        public System.Int32? MaxPasskeysAllowed { get; set; }

        //      C# -> System.Boolean? PasswordlessLoginAllowed
        // GraphQL -> passwordlessLoginAllowed: Boolean (scalar)
        [JsonProperty("passwordlessLoginAllowed")]
        public System.Boolean? PasswordlessLoginAllowed { get; set; }


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

    } // class PasskeyConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types