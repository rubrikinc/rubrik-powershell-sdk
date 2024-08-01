// AddRecoveryOrgInput.cs
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
    #region AddRecoveryOrgInput

    public class AddRecoveryOrgInput: IInput
    {
        #region members

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? OrgNaturalId
        // GraphQL -> orgNaturalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgNaturalId")]
        public System.String? OrgNaturalId { get; set; }

        //      C# -> SaasEnvironmentType? EnvironmentType
        // GraphQL -> environmentType: SaasEnvironmentType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("environmentType")]
        public SaasEnvironmentType? EnvironmentType { get; set; }

        //      C# -> SaasAppType? SaasAppType
        // GraphQL -> saasAppType: SaasAppType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("saasAppType")]
        public SaasAppType? SaasAppType { get; set; }


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

    } // class AddRecoveryOrgInput
    #endregion

} // namespace RubrikSecurityCloud.Types