// SetupSalesforceOrganizationInput.cs
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
    #region SetupSalesforceOrganizationInput

    public class SetupSalesforceOrganizationInput: IInput
    {
        #region members

        //      C# -> System.String? OrgNaturalId
        // GraphQL -> orgNaturalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgNaturalId")]
        public System.String? OrgNaturalId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? StorageRegion
        // GraphQL -> storageRegion: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storageRegion")]
        public System.String? StorageRegion { get; set; }

        //      C# -> SalesforceApiLimits? ApiLimits
        // GraphQL -> apiLimits: SalesforceApiLimits! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("apiLimits")]
        public SalesforceApiLimits? ApiLimits { get; set; }

        //      C# -> SaasEnvironmentType? EnvironmentType
        // GraphQL -> environmentType: SaasEnvironmentType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("environmentType")]
        public SaasEnvironmentType? EnvironmentType { get; set; }


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

    } // class SetupSalesforceOrganizationInput
    #endregion

} // namespace RubrikSecurityCloud.Types