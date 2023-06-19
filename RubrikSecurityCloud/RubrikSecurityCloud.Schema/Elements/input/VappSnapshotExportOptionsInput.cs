// VappSnapshotExportOptionsInput.cs
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
    #region VappSnapshotExportOptionsInput

    public class VappSnapshotExportOptionsInput: IInput
    {
        #region members

        //      C# -> GetVappSnapshotExportOptionsRequestExportMode? ExportMode
        // GraphQL -> exportMode: GetVappSnapshotExportOptionsRequestExportMode! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("exportMode")]
        public GetVappSnapshotExportOptionsRequestExportMode? ExportMode { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetOrgVdcId
        // GraphQL -> targetOrgVdcId: String (scalar)
        [JsonProperty("targetOrgVdcId")]
        public System.String? TargetOrgVdcId { get; set; }

        //      C# -> System.String? TargetVappId
        // GraphQL -> targetVappId: String (scalar)
        [JsonProperty("targetVappId")]
        public System.String? TargetVappId { get; set; }


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

    } // class VappSnapshotExportOptionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types