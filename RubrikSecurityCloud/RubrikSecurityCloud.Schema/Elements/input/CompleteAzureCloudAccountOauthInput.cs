// CompleteAzureCloudAccountOauthInput.cs
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
    #region CompleteAzureCloudAccountOauthInput

    public class CompleteAzureCloudAccountOauthInput: IInput
    {
        #region members

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.String? TenantDomainName
        // GraphQL -> tenantDomainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantDomainName")]
        public System.String? TenantDomainName { get; set; }

        //      C# -> System.String? AuthorizationCode
        // GraphQL -> authorizationCode: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("authorizationCode")]
        public System.String? AuthorizationCode { get; set; }

        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("redirectUrl")]
        public System.String? RedirectUrl { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecretKey
        // GraphQL -> appSecretKey: String (scalar)
        [JsonProperty("appSecretKey")]
        public System.String? AppSecretKey { get; set; }

        //      C# -> System.Boolean? ShouldSkipPermissionChecks
        // GraphQL -> shouldSkipPermissionChecks: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldSkipPermissionChecks")]
        public System.Boolean? ShouldSkipPermissionChecks { get; set; }

        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType (enum)
        [JsonProperty("azureCloudType")]
        public AzureCloudType? AzureCloudType { get; set; }

        //      C# -> AzureOauthResource? Resource
        // GraphQL -> resource: AzureOauthResource (enum)
        [JsonProperty("resource")]
        public AzureOauthResource? Resource { get; set; }

        //      C# -> System.Boolean? PerformBasicOauth
        // GraphQL -> performBasicOauth: Boolean (scalar)
        [JsonProperty("performBasicOauth")]
        public System.Boolean? PerformBasicOauth { get; set; }


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

    } // class CompleteAzureCloudAccountOauthInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types