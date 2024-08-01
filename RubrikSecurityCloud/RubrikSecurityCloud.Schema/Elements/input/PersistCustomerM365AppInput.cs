// PersistCustomerM365AppInput.cs
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
    #region PersistCustomerM365AppInput

    public class PersistCustomerM365AppInput: IInput
    {
        #region members

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> M365Cloud? M365CloudType
        // GraphQL -> m365CloudType: M365Cloud! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("m365CloudType")]
        public M365Cloud? M365CloudType { get; set; }

        //      C# -> O365AppType? AppType
        // GraphQL -> appType: O365AppType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("appType")]
        public O365AppType? AppType { get; set; }

        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appClientId")]
        public System.String? AppClientId { get; set; }

        //      C# -> System.String? AppClientSecret
        // GraphQL -> appClientSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appClientSecret")]
        public System.String? AppClientSecret { get; set; }

        //      C# -> System.String? AppCertificate
        // GraphQL -> appCertificate: String (scalar)
        [JsonProperty("appCertificate")]
        public System.String? AppCertificate { get; set; }

        //      C# -> System.String? AppPrivateKey
        // GraphQL -> appPrivateKey: String (scalar)
        [JsonProperty("appPrivateKey")]
        public System.String? AppPrivateKey { get; set; }


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

    } // class PersistCustomerM365AppInput
    #endregion

} // namespace RubrikSecurityCloud.Types