// CertificateImportRequestInput.cs
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
    #region CertificateImportRequestInput

    public class CertificateImportRequestInput: IInput
    {
        #region members

        //      C# -> System.String? CsrId
        // GraphQL -> csrId: String (scalar)
        [JsonProperty("csrId")]
        public System.String? CsrId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? PrivateKey
        // GraphQL -> privateKey: String (scalar)
        [JsonProperty("privateKey")]
        public System.String? PrivateKey { get; set; }

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PemFile
        // GraphQL -> pemFile: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("pemFile")]
        public System.String? PemFile { get; set; }


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

    } // class CertificateImportRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types