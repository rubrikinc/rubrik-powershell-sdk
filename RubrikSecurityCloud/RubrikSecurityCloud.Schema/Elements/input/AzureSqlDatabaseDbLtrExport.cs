// AzureSqlDatabaseDbLtrExport.cs
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
    #region AzureSqlDatabaseDbLtrExport

    public class AzureSqlDatabaseDbLtrExport: IInput
    {
        #region members

        //      C# -> System.String? SourceSnapshotRubrikId
        // GraphQL -> sourceSnapshotRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceSnapshotRubrikId")]
        public System.String? SourceSnapshotRubrikId { get; set; }

        //      C# -> System.String? DestinationResourceGroupName
        // GraphQL -> destinationResourceGroupName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationResourceGroupName")]
        public System.String? DestinationResourceGroupName { get; set; }

        //      C# -> System.String? DestinationServerName
        // GraphQL -> destinationServerName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationServerName")]
        public System.String? DestinationServerName { get; set; }

        //      C# -> System.String? DestinationRegionName
        // GraphQL -> destinationRegionName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationRegionName")]
        public System.String? DestinationRegionName { get; set; }

        //      C# -> AzureSqlBackupStorageRedundancyType? DbBackupRedundancy
        // GraphQL -> dbBackupRedundancy: AzureSqlBackupStorageRedundancyType (enum)
        [JsonProperty("dbBackupRedundancy")]
        public AzureSqlBackupStorageRedundancyType? DbBackupRedundancy { get; set; }


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

    } // class AzureSqlDatabaseDbLtrExport
    #endregion

} // namespace RubrikSecurityCloud.Types