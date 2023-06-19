// ValidateCertificateInput.cs
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
    #region ValidateCertificateInput

    public class ValidateCertificateInput: IInput
    {
        #region members

        //      C# -> System.String? CertificatePem
        // GraphQL -> certificatePem: String (scalar)
        [JsonProperty("certificatePem")]
        public System.String? CertificatePem { get; set; }

        //      C# -> System.String? PrivateKey
        // GraphQL -> privateKey: String (scalar)
        [JsonProperty("privateKey")]
        public System.String? PrivateKey { get; set; }

        //      C# -> System.Int64? CsrId
        // GraphQL -> csrId: Long (scalar)
        [JsonProperty("csrId")]
        public System.Int64? CsrId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


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

    } // class ValidateCertificateInput
    #endregion

} // namespace RubrikSecurityCloud.Types