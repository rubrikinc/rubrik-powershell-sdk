### BulkExportMssqlDbConfigInput
Supported in v9.2+

- allowOverwrite: System.Boolean
  - Supported in v9.2+
      Boolean value determining whether an existing database can be overwritten by a database that was exported from a backup. Set to 'false' to prevent overwrites. This is the default. Set to 'true' to allow overwrites.
- sourceDatabaseIds: list of System.Strings
  - Supported in v9.2+
      List of Microsoft SQL database IDs to export.
- targetDataFilePath: System.String
  - Supported in v9.2+
      Target path used to store all data files.
- targetLogFilePath: System.String
  - Supported in v9.2+
      Target path used to store all log files.
- finishRecovery: System.Boolean
  - Supported in v9.2+
      Boolean value determining which recovery option to use during a database restore. When this value is 'true', the database is restored using the RECOVERY option and is fully functional at the end of the restore operation. When this value is 'false', the database is restored using the NORECOVERY option and remains in recovering mode at the end of the restore operation.
- sourceInstanceIds: list of System.Strings
  - Required. Supported in v9.2+
      List of the SQL Server instance IDs used to to export all databases except system databases.
- recoveryPoint: MssqlRecoveryPointInput
  - Supported in v9.2+
- targetInstanceId: System.String
  - Required. Supported in v9.2+
      ID of the SQL Server instance for the new databases.
