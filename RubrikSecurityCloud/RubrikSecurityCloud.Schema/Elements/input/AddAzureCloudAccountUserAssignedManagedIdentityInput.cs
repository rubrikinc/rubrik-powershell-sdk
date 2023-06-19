// AddAzureCloudAccountUserAssignedManagedIdentityInput.cs
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
    #region AddAzureCloudAccountUserAssignedManagedIdentityInput

    public class AddAzureCloudAccountUserAssignedManagedIdentityInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }


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

    } // class AddAzureCloudAccountUserAssignedManagedIdentityInput
    #endregion

} // namespace RubrikSecurityCloud.Types