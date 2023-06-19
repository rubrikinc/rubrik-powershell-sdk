// SetAzureCloudAccountCustomerAppCredentialsInput.cs
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
    #region SetAzureCloudAccountCustomerAppCredentialsInput

    public class SetAzureCloudAccountCustomerAppCredentialsInput: IInput
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecretKey
        // GraphQL -> appSecretKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appSecretKey")]
        public System.String? AppSecretKey { get; set; }

        //      C# -> System.String? AppTenantId
        // GraphQL -> appTenantId: String (scalar)
        [JsonProperty("appTenantId")]
        public System.String? AppTenantId { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? TenantDomainName
        // GraphQL -> tenantDomainName: String (scalar)
        [JsonProperty("tenantDomainName")]
        public System.String? TenantDomainName { get; set; }

        //      C# -> System.Boolean? ShouldReplace
        // GraphQL -> shouldReplace: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldReplace")]
        public System.Boolean? ShouldReplace { get; set; }

        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureCloudType")]
        public AzureCloudType? AzureCloudType { get; set; }


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

    } // class SetAzureCloudAccountCustomerAppCredentialsInput
    #endregion

} // namespace RubrikSecurityCloud.Types