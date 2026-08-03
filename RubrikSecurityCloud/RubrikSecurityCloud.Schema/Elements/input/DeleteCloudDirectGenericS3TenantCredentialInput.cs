// DeleteCloudDirectGenericS3TenantCredentialInput.cs
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
    #region DeleteCloudDirectGenericS3TenantCredentialInput

    public class DeleteCloudDirectGenericS3TenantCredentialInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? SystemId
        // GraphQL -> systemId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("systemId")]
        public System.String? SystemId { get; set; }

        //      C# -> System.String? NamespaceUuid
        // GraphQL -> namespaceUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("namespaceUuid")]
        public System.String? NamespaceUuid { get; set; }


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

    } // class DeleteCloudDirectGenericS3TenantCredentialInput
    #endregion

} // namespace RubrikSecurityCloud.Types