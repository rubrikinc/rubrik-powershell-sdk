// StartGitHubAppSetupInput.cs
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
    #region StartGitHubAppSetupInput

    public class StartGitHubAppSetupInput: IInput
    {
        #region members

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> List<PermissionsGroup>? AppPurposes
        // GraphQL -> appPurposes: [PermissionsGroup!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("appPurposes")]
        public List<PermissionsGroup>? AppPurposes { get; set; }

        //      C# -> System.String? OrganizationUrl
        // GraphQL -> organizationUrl: String (scalar)
        [JsonProperty("organizationUrl")]
        public System.String? OrganizationUrl { get; set; }


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

    } // class StartGitHubAppSetupInput
    #endregion

} // namespace RubrikSecurityCloud.Types