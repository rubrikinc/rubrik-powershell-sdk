// FlashBladeSystemParametersInput.cs
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
    #region FlashBladeSystemParametersInput

    public class FlashBladeSystemParametersInput: IInput
    {
        #region members

        //      C# -> System.Boolean? HasSmbSupport
        // GraphQL -> hasSmbSupport: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hasSmbSupport")]
        public System.Boolean? HasSmbSupport { get; set; }

        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        [JsonProperty("apiCertificate")]
        public System.String? ApiCertificate { get; set; }

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> GenericNasSystemCredentialsInput? SmbCredentials
        // GraphQL -> smbCredentials: GenericNasSystemCredentialsInput (input)
        [JsonProperty("smbCredentials")]
        public GenericNasSystemCredentialsInput? SmbCredentials { get; set; }


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

    } // class FlashBladeSystemParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types