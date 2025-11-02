// NasConfigInput.cs
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
    #region NasConfigInput

    public class NasConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        [JsonProperty("apiCertificate")]
        public System.String? ApiCertificate { get; set; }

        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        [JsonProperty("apiEndpoint")]
        public System.String? ApiEndpoint { get; set; }

        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        [JsonProperty("apiHostname")]
        public System.String? ApiHostname { get; set; }

        //      C# -> System.String? ApiPassword
        // GraphQL -> apiPassword: String (scalar)
        [JsonProperty("apiPassword")]
        public System.String? ApiPassword { get; set; }

        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        [JsonProperty("apiUsername")]
        public System.String? ApiUsername { get; set; }

        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vendorType")]
        public System.String? VendorType { get; set; }

        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        [JsonProperty("zoneName")]
        public System.String? ZoneName { get; set; }

        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        [JsonProperty("isSnapdiffEnabled")]
        public System.Boolean? IsSnapdiffEnabled { get; set; }

        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        [JsonProperty("isIsilonChangelistEnabled")]
        public System.Boolean? IsIsilonChangelistEnabled { get; set; }

        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        [JsonProperty("isNetAppSnapDiffEnabled")]
        public System.Boolean? IsNetAppSnapDiffEnabled { get; set; }

        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        [JsonProperty("isShareAutoDiscoveryEnabled")]
        public System.Boolean? IsShareAutoDiscoveryEnabled { get; set; }

        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        [JsonProperty("isNutanixCftEnabled")]
        public System.Boolean? IsNutanixCftEnabled { get; set; }


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

    } // class NasConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types