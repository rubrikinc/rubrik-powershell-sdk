### StartExportAzureSqlManagedInstanceDbJobInput
Input for the job to export the specified Azure SQL Managed Instance database.

- azureSqlManagedInstanceDbLtrExportInput: AzureSqlManagedInstanceDbLtrExport
  - Input for exporting from Long Term Retention (LTR) backup.
- azureSqlManagedInstanceDbPitExportInput: AzureSqlManagedInstanceDbPitExport
  - Input for exporting from Point-in-Time (PiT) backup.
- destinationDatabaseName: System.String
  - Name of the exported Azure SQL Managed Instance database.
- destinationManagedInstanceName: System.String
  - Name of the Azure SQL Managed Instance in which database is being exported.
- destinationManagedInstanceRubrikId: System.String
  - Destination Rubrik ID of the Asure SQL Managed Instance to which export will be done.
- destinationResourceGroupName: System.String
  - Resource Group in which database is being exported.
- persistentBackupExportInput: AzureSqlPersistentBackupExportInput
  - Input for exporting from Rubrik managed persistent backup.
- sourceManagedInstanceDatabaseRubrikId: System.String
  - Rubrik ID of the Azure SQL Managed Instance Database to be exported.
