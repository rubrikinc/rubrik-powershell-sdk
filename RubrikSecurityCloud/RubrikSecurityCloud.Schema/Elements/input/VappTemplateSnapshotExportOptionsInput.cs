// VappTemplateSnapshotExportOptionsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region VappTemplateSnapshotExportOptionsInput

    public class VappTemplateSnapshotExportOptionsInput: IInput
    {
        #region members

        //      C# -> System.String? OrgVdcId
        // GraphQL -> orgVdcId: String (scalar)
        [JsonProperty("orgVdcId")]
        public System.String? OrgVdcId { get; set; }

        //      C# -> System.String? CatalogId
        // GraphQL -> catalogId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("catalogId")]
        public System.String? CatalogId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


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

    } // class VappTemplateSnapshotExportOptionsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types