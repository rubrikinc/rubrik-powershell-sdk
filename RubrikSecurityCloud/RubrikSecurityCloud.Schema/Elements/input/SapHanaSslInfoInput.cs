// SapHanaSslInfoInput.cs
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
    #region SapHanaSslInfoInput

    public class SapHanaSslInfoInput: IInput
    {
        #region members

        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String (scalar)
        [JsonProperty("cryptoLibPath")]
        public System.String? CryptoLibPath { get; set; }

        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String (scalar)
        [JsonProperty("hostNameInCertificate")]
        public System.String? HostNameInCertificate { get; set; }

        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean (scalar)
        [JsonProperty("shouldEncrypt")]
        public System.Boolean? ShouldEncrypt { get; set; }

        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean (scalar)
        [JsonProperty("shouldValidateCertificate")]
        public System.Boolean? ShouldValidateCertificate { get; set; }

        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String (scalar)
        [JsonProperty("trustStorePath")]
        public System.String? TrustStorePath { get; set; }

        //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionProvider")]
        public SapHanaSslInfoEncryptionProvider? EncryptionProvider { get; set; }

        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("keyStorePath")]
        public System.String? KeyStorePath { get; set; }


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

    } // class SapHanaSslInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types