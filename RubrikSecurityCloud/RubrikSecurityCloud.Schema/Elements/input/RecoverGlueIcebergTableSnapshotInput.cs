// RecoverGlueIcebergTableSnapshotInput.cs
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
    #region RecoverGlueIcebergTableSnapshotInput

    public class RecoverGlueIcebergTableSnapshotInput: IInput
    {
        #region members

        //      C# -> System.String? SourceTableId
        // GraphQL -> sourceTableId: UUID (scalar)
        [JsonProperty("sourceTableId")]
        public System.String? SourceTableId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> GlueIcebergInPlaceRecoveryTarget? InPlace
        // GraphQL -> inPlace: GlueIcebergInPlaceRecoveryTarget (input)
        [JsonProperty("inPlace")]
        public GlueIcebergInPlaceRecoveryTarget? InPlace { get; set; }

        //      C# -> GlueIcebergExportToExistingTableRecoveryTarget? ExportToExistingTable
        // GraphQL -> exportToExistingTable: GlueIcebergExportToExistingTableRecoveryTarget (input)
        [JsonProperty("exportToExistingTable")]
        public GlueIcebergExportToExistingTableRecoveryTarget? ExportToExistingTable { get; set; }

        //      C# -> GlueIcebergExportToNewTableRecoveryTarget? ExportToNewTable
        // GraphQL -> exportToNewTable: GlueIcebergExportToNewTableRecoveryTarget (input)
        [JsonProperty("exportToNewTable")]
        public GlueIcebergExportToNewTableRecoveryTarget? ExportToNewTable { get; set; }


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

    } // class RecoverGlueIcebergTableSnapshotInput
    #endregion

} // namespace RubrikSecurityCloud.Types