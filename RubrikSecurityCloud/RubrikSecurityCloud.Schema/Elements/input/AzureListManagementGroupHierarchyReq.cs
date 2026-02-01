// AzureListManagementGroupHierarchyReq.cs
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
    #region AzureListManagementGroupHierarchyReq

    public class AzureListManagementGroupHierarchyReq: IInput
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

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? ManagementGroupId
        // GraphQL -> managementGroupId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("managementGroupId")]
        public System.String? ManagementGroupId { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!] (enum)
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> System.Boolean? ShouldRecurse
        // GraphQL -> shouldRecurse: Boolean (scalar)
        [JsonProperty("shouldRecurse")]
        public System.Boolean? ShouldRecurse { get; set; }


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

    } // class AzureListManagementGroupHierarchyReq
    #endregion

} // namespace RubrikSecurityCloud.Types