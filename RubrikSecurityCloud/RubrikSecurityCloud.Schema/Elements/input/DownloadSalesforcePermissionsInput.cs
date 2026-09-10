// DownloadSalesforcePermissionsInput.cs
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
    #region DownloadSalesforcePermissionsInput

    public class DownloadSalesforcePermissionsInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> List<System.String>? PermissionIds
        // GraphQL -> permissionIds: [UUID!] (scalar)
        [JsonProperty("permissionIds")]
        public List<System.String>? PermissionIds { get; set; }

        //      C# -> PermissionReportType? PermissionReportType
        // GraphQL -> permissionReportType: PermissionReportType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("permissionReportType")]
        public PermissionReportType? PermissionReportType { get; set; }

        //      C# -> List<System.String>? Path
        // GraphQL -> path: [String!] (scalar)
        [JsonProperty("path")]
        public List<System.String>? Path { get; set; }

        //      C# -> List<PermissionType>? PermissionTypes
        // GraphQL -> permissionTypes: [PermissionType!] (enum)
        [JsonProperty("permissionTypes")]
        public List<PermissionType>? PermissionTypes { get; set; }


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

    } // class DownloadSalesforcePermissionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types