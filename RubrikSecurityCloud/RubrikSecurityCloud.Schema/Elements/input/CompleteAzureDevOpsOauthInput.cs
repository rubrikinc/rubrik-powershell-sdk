// CompleteAzureDevOpsOauthInput.cs
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
    #region CompleteAzureDevOpsOauthInput

    public class CompleteAzureDevOpsOauthInput: IInput
    {
        #region members

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: UUID (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> System.String? TenantDomainName
        // GraphQL -> tenantDomainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantDomainName")]
        public System.String? TenantDomainName { get; set; }

        //      C# -> System.String? RedirectUrl
        // GraphQL -> redirectUrl: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("redirectUrl")]
        public System.String? RedirectUrl { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.Boolean? KeepRefreshToken
        // GraphQL -> keepRefreshToken: Boolean (scalar)
        [JsonProperty("keepRefreshToken")]
        public System.Boolean? KeepRefreshToken { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> AzureDevopsAuthMethod? AzureDevopsAuthMethod
        // GraphQL -> azureDevopsAuthMethod: AzureDevopsAuthMethod (input)
        [JsonProperty("azureDevopsAuthMethod")]
        public AzureDevopsAuthMethod? AzureDevopsAuthMethod { get; set; }


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

    } // class CompleteAzureDevOpsOauthInput
    #endregion

} // namespace RubrikSecurityCloud.Types