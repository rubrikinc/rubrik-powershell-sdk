// CreatePasskeyInput.cs
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
    #region CreatePasskeyInput

    public class CreatePasskeyInput: IInput
    {
        #region members

        //      C# -> System.String? AdditionalConfig
        // GraphQL -> additionalConfig: String (scalar)
        [JsonProperty("additionalConfig")]
        public System.String? AdditionalConfig { get; set; }

        //      C# -> System.String? Os
        // GraphQL -> os: String (scalar)
        [JsonProperty("os")]
        public System.String? Os { get; set; }

        //      C# -> System.String? Browser
        // GraphQL -> browser: String (scalar)
        [JsonProperty("browser")]
        public System.String? Browser { get; set; }

        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("credentialId")]
        public System.String? CredentialId { get; set; }

        //      C# -> System.String? PasskeyName
        // GraphQL -> passkeyName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("passkeyName")]
        public System.String? PasskeyName { get; set; }

        //      C# -> System.String? PublicKey
        // GraphQL -> publicKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("publicKey")]
        public System.String? PublicKey { get; set; }

        //      C# -> KeyTypeEnumType? KeyType
        // GraphQL -> keyType: KeyTypeEnumType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("keyType")]
        public KeyTypeEnumType? KeyType { get; set; }

        //      C# -> System.String? ClientData
        // GraphQL -> clientData: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientData")]
        public System.String? ClientData { get; set; }

        //      C# -> System.String? AuthData
        // GraphQL -> authData: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("authData")]
        public System.String? AuthData { get; set; }


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

    } // class CreatePasskeyInput
    #endregion

} // namespace RubrikSecurityCloud.Types