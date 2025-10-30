// StartAzureAdAppUpdateInput.cs
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
    #region StartAzureAdAppUpdateInput

    public class StartAzureAdAppUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> AzureAdApp? AzureAdApp
        // GraphQL -> azureAdApp: AzureAdApp (input)
        [JsonProperty("azureAdApp")]
        public AzureAdApp? AzureAdApp { get; set; }

        //      C# -> PermissionAccessMode? PermissionAccessMode
        // GraphQL -> permissionAccessMode: PermissionAccessMode (enum)
        [JsonProperty("permissionAccessMode")]
        public PermissionAccessMode? PermissionAccessMode { get; set; }

        //      C# -> List<AzureAdObjectType>? MissingObjectTypes
        // GraphQL -> missingObjectTypes: [AzureAdObjectType!] (enum)
        [JsonProperty("missingObjectTypes")]
        public List<AzureAdObjectType>? MissingObjectTypes { get; set; }


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

    } // class StartAzureAdAppUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types