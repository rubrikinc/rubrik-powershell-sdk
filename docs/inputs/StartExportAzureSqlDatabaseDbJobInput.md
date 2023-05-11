### StartExportAzureSqlDatabaseDbJobInput
Input for the job to export the specified Azure SQL Database.

- azureSqlDatabaseDbLtrExportInput: AzureSqlDatabaseDbLtrExport
  - Input for exporting from Long Term Retention (LTR) backup.
- azureSqlDatabaseDbPitExportInput: AzureSqlDatabaseDbPitExport
  - Input for exporting from Point-in-Time (PiT) backup.
- destinationDatabaseName: System.String
  - Name of the exported Azure SQL Database.
- destinationServerRubrikId: System.String
  - Rubrik ID of the server to which export will be done.
- elasticPoolName: System.String
  - Name of the elastic pool for the exported database.
- persistentBackupExportInput: AzureSqlPersistentBackupExportInput
  - Input for exporting from Rubrik managed persistent backup.
- shouldExportTags: System.Boolean
  - Specifies whether the tags will be exported to the new Azure SQL Database.
- sourceDatabaseRubrikId: System.String
  - Rubrik ID of the Azure SQL Database instance to be exported.
