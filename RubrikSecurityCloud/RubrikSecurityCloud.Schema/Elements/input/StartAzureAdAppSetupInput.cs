// StartAzureAdAppSetupInput.cs
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
    #region StartAzureAdAppSetupInput

    public class StartAzureAdAppSetupInput: IInput
    {
        #region members

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> AzureAdRegion? Region
        // GraphQL -> region: AzureAdRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureAdRegion? Region { get; set; }

        //      C# -> AzureAdApp? AzureAdApp
        // GraphQL -> azureAdApp: AzureAdApp (input)
        [JsonProperty("azureAdApp")]
        public AzureAdApp? AzureAdApp { get; set; }

        //      C# -> PermissionAccessMode? PermissionAccessMode
        // GraphQL -> permissionAccessMode: PermissionAccessMode (enum)
        [JsonProperty("permissionAccessMode")]
        public PermissionAccessMode? PermissionAccessMode { get; set; }


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

    } // class StartAzureAdAppSetupInput
    #endregion

} // namespace RubrikSecurityCloud.Types