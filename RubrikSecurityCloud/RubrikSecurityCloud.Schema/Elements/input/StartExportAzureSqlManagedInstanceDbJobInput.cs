// StartExportAzureSqlManagedInstanceDbJobInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartExportAzureSqlManagedInstanceDbJobInput

    public class StartExportAzureSqlManagedInstanceDbJobInput
    {
        #region members
        //      C# -> System.String? SourceManagedInstanceDatabaseRubrikId
        // GraphQL -> sourceManagedInstanceDatabaseRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceManagedInstanceDatabaseRubrikId")]
        public System.String? SourceManagedInstanceDatabaseRubrikId { get; set; }

        //      C# -> System.String? DestinationManagedInstanceRubrikId
        // GraphQL -> destinationManagedInstanceRubrikId: UUID (scalar)
        [JsonProperty("destinationManagedInstanceRubrikId")]
        public System.String? DestinationManagedInstanceRubrikId { get; set; }

        //      C# -> System.String? DestinationDatabaseName
        // GraphQL -> destinationDatabaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationDatabaseName")]
        public System.String? DestinationDatabaseName { get; set; }

        //      C# -> System.String? DestinationManagedInstanceName
        // GraphQL -> destinationManagedInstanceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationManagedInstanceName")]
        public System.String? DestinationManagedInstanceName { get; set; }

        //      C# -> System.String? DestinationResourceGroupName
        // GraphQL -> destinationResourceGroupName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationResourceGroupName")]
        public System.String? DestinationResourceGroupName { get; set; }

        //      C# -> AzureSqlManagedInstanceDbPitExport? AzureSqlManagedInstanceDbPitExportInput
        // GraphQL -> azureSqlManagedInstanceDbPitExportInput: AzureSqlManagedInstanceDbPitExport (input)
        [JsonProperty("azureSqlManagedInstanceDbPitExportInput")]
        public AzureSqlManagedInstanceDbPitExport? AzureSqlManagedInstanceDbPitExportInput { get; set; }

        //      C# -> AzureSqlManagedInstanceDbLtrExport? AzureSqlManagedInstanceDbLtrExportInput
        // GraphQL -> azureSqlManagedInstanceDbLtrExportInput: AzureSqlManagedInstanceDbLtrExport (input)
        [JsonProperty("azureSqlManagedInstanceDbLtrExportInput")]
        public AzureSqlManagedInstanceDbLtrExport? AzureSqlManagedInstanceDbLtrExportInput { get; set; }

        //      C# -> AzureSqlPersistentBackupExportInput? PersistentBackupExportInput
        // GraphQL -> persistentBackupExportInput: AzureSqlPersistentBackupExportInput (input)
        [JsonProperty("persistentBackupExportInput")]
        public AzureSqlPersistentBackupExportInput? PersistentBackupExportInput { get; set; }

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

    } // class StartExportAzureSqlManagedInstanceDbJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types