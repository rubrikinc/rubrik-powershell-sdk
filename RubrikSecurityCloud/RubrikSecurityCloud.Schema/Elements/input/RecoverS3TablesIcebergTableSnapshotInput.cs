// RecoverS3TablesIcebergTableSnapshotInput.cs
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
    #region RecoverS3TablesIcebergTableSnapshotInput

    public class RecoverS3TablesIcebergTableSnapshotInput: IInput
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

        //      C# -> S3TablesIcebergInPlaceRecoveryTarget? InPlace
        // GraphQL -> inPlace: S3TablesIcebergInPlaceRecoveryTarget (input)
        [JsonProperty("inPlace")]
        public S3TablesIcebergInPlaceRecoveryTarget? InPlace { get; set; }

        //      C# -> S3TablesIcebergExportToExistingTableRecoveryTarget? ExportToExistingTable
        // GraphQL -> exportToExistingTable: S3TablesIcebergExportToExistingTableRecoveryTarget (input)
        [JsonProperty("exportToExistingTable")]
        public S3TablesIcebergExportToExistingTableRecoveryTarget? ExportToExistingTable { get; set; }

        //      C# -> S3TablesIcebergExportToNewTableRecoveryTarget? ExportToNewTable
        // GraphQL -> exportToNewTable: S3TablesIcebergExportToNewTableRecoveryTarget (input)
        [JsonProperty("exportToNewTable")]
        public S3TablesIcebergExportToNewTableRecoveryTarget? ExportToNewTable { get; set; }


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

    } // class RecoverS3TablesIcebergTableSnapshotInput
    #endregion

} // namespace RubrikSecurityCloud.Types