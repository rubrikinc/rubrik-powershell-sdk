// InsertCustomerO365AppInput.cs
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
    #region InsertCustomerO365AppInput

    public class InsertCustomerO365AppInput: IInput
    {
        #region members

        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appType")]
        public System.String? AppType { get; set; }

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

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? Base64AppCertificate
        // GraphQL -> base64AppCertificate: String (scalar)
        [JsonProperty("base64AppCertificate")]
        public System.String? Base64AppCertificate { get; set; }

        //      C# -> System.String? Base64AppPrivateKey
        // GraphQL -> base64AppPrivateKey: String (scalar)
        [JsonProperty("base64AppPrivateKey")]
        public System.String? Base64AppPrivateKey { get; set; }

        //      C# -> System.Boolean? UpdateAppCredentials
        // GraphQL -> updateAppCredentials: Boolean (scalar)
        [JsonProperty("updateAppCredentials")]
        public System.Boolean? UpdateAppCredentials { get; set; }

        //      C# -> DateTime? AppSecretExpiry
        // GraphQL -> appSecretExpiry: DateTime (scalar)
        [JsonProperty("appSecretExpiry")]
        public DateTime? AppSecretExpiry { get; set; }

        //      C# -> DateTime? AppCertificateExpiry
        // GraphQL -> appCertificateExpiry: DateTime (scalar)
        [JsonProperty("appCertificateExpiry")]
        public DateTime? AppCertificateExpiry { get; set; }


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

    } // class InsertCustomerO365AppInput
    #endregion

} // namespace RubrikSecurityCloud.Types