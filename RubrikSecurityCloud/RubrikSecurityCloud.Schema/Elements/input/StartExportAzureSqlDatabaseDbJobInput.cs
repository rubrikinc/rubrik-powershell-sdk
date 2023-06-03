// StartExportAzureSqlDatabaseDbJobInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region StartExportAzureSqlDatabaseDbJobInput

    public class StartExportAzureSqlDatabaseDbJobInput: IInput
    {
        #region members

        //      C# -> System.String? SourceDatabaseRubrikId
        // GraphQL -> sourceDatabaseRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceDatabaseRubrikId")]
        public System.String? SourceDatabaseRubrikId { get; set; }

        //      C# -> System.String? DestinationDatabaseName
        // GraphQL -> destinationDatabaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationDatabaseName")]
        public System.String? DestinationDatabaseName { get; set; }

        //      C# -> System.String? DestinationServerRubrikId
        // GraphQL -> destinationServerRubrikId: UUID (scalar)
        [JsonProperty("destinationServerRubrikId")]
        public System.String? DestinationServerRubrikId { get; set; }

        //      C# -> System.String? ElasticPoolName
        // GraphQL -> elasticPoolName: String (scalar)
        [JsonProperty("elasticPoolName")]
        public System.String? ElasticPoolName { get; set; }

        //      C# -> System.Boolean? ShouldExportTags
        // GraphQL -> shouldExportTags: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldExportTags")]
        public System.Boolean? ShouldExportTags { get; set; }

        //      C# -> AzureSqlDatabaseDbPitExport? AzureSqlDatabaseDbPitExportInput
        // GraphQL -> azureSqlDatabaseDbPitExportInput: AzureSqlDatabaseDbPitExport (input)
        [JsonProperty("azureSqlDatabaseDbPitExportInput")]
        public AzureSqlDatabaseDbPitExport? AzureSqlDatabaseDbPitExportInput { get; set; }

        //      C# -> AzureSqlDatabaseDbLtrExport? AzureSqlDatabaseDbLtrExportInput
        // GraphQL -> azureSqlDatabaseDbLtrExportInput: AzureSqlDatabaseDbLtrExport (input)
        [JsonProperty("azureSqlDatabaseDbLtrExportInput")]
        public AzureSqlDatabaseDbLtrExport? AzureSqlDatabaseDbLtrExportInput { get; set; }

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

    } // class StartExportAzureSqlDatabaseDbJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types