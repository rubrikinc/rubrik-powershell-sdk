// NutanixFileServerParametersInput.cs
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
    #region NutanixFileServerParametersInput

    public class NutanixFileServerParametersInput: IInput
    {
        #region members

        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        [JsonProperty("apiCertificate")]
        public System.String? ApiCertificate { get; set; }

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> System.String? ApiPassword
        // GraphQL -> apiPassword: String (scalar)
        [JsonProperty("apiPassword")]
        public System.String? ApiPassword { get; set; }

        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        [JsonProperty("apiUsername")]
        public System.String? ApiUsername { get; set; }

        //      C# -> System.Boolean? HasSmbSupport
        // GraphQL -> hasSmbSupport: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hasSmbSupport")]
        public System.Boolean? HasSmbSupport { get; set; }

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

    } // class NutanixFileServerParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types