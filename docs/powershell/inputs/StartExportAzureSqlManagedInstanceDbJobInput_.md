### StartExportAzureSqlManagedInstanceDbJobInput
Input for the job to export the specified Azure SQL Managed Instance database.

- sourceManagedInstanceDatabaseRubrikId: System.String
  - Rubrik ID of the Azure SQL Managed Instance Database to be exported.
- destinationManagedInstanceRubrikId: System.String
  - Destination Rubrik ID of the Asure SQL Managed Instance to which export will be done.
- destinationDatabaseName: System.String
  - Name of the exported Azure SQL Managed Instance database.
- destinationManagedInstanceName: System.String
  - Name of the Azure SQL Managed Instance in which database is being exported.
- destinationResourceGroupName: System.String
  - Resource Group in which database is being exported.
- azureSqlManagedInstanceDbPitExportInput: AzureSqlManagedInstanceDbPitExport
  - Input for exporting from Point-in-Time (PiT) backup.
- azureSqlManagedInstanceDbLtrExportInput: AzureSqlManagedInstanceDbLtrExport
  - Input for exporting from Long Term Retention (LTR) backup.
- persistentBackupExportInput: AzureSqlPersistentBackupExportInput
  - Input for exporting from Rubrik managed persistent backup.
- serviceTier: System.String
  - Input for service tier selected for the export of the database.
- serviceObjectiveName: System.String
  - Input for service object name selected for the export of the database.
