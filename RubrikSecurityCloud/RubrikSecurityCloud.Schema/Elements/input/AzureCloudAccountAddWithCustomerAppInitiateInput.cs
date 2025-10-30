// AzureCloudAccountAddWithCustomerAppInitiateInput.cs
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
    #region AzureCloudAccountAddWithCustomerAppInitiateInput

    public class AzureCloudAccountAddWithCustomerAppInitiateInput: IInput
    {
        #region members

        //      C# -> System.String? TenantDomainName
        // GraphQL -> tenantDomainName: String (scalar)
        [JsonProperty("tenantDomainName")]
        public System.String? TenantDomainName { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecretKey
        // GraphQL -> appSecretKey: String (scalar)
        [JsonProperty("appSecretKey")]
        public System.String? AppSecretKey { get; set; }

        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String (scalar)
        [JsonProperty("redirectUrl")]
        public System.String? RedirectUrl { get; set; }


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

    } // class AzureCloudAccountAddWithCustomerAppInitiateInput
    #endregion

} // namespace RubrikSecurityCloud.Types