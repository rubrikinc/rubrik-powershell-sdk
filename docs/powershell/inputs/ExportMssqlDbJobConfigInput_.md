### ExportMssqlDbJobConfigInput
Supported in v5.0+

- allowOverwrite: System.Boolean
  - Supported in v5.0+
      v5.0-v9.1: A Boolean value that determines whether an existing database can be overwritten by a database this is exported from a backup. Set to false to prevent overwrites. This is the default. Set to true to allow overwrites.
      v9.2+: Boolean value determining whether an existing database can be overwritten by a database that is exported from a backup. Set to false to prevent overwrites. This is the default. Set to true to allow overwrites.
- finishRecovery: System.Boolean
  - Supported in v5.0+
      v5.0-v9.1: A Boolean value that determines the recovery option to use during database restore. When this value is 'true', the database is restored using the RECOVERY option and is fully functional at the end of the restore operation. When this value is 'false', the database is restored using the NORECOVERY option and remains in recovering mode at the end of the restore operation.
      v9.2+: Boolean value determining which recovery option to use during a database restore. When this value is 'true', the database is restored using the RECOVERY option and is fully functional at the end of the restore operation. When this value is 'false', the database is restored using the NORECOVERY option and remains in recovering mode at the end of the restore operation.
- maxDataStreams: System.Int32
  - Supported in v5.0+
      Maximum number of parallel data streams that can be used to copy data to the target system.
- targetDataFilePath: System.String
  - Supported in v5.0+
      v5.0-v9.1: The target path to store all data files.
      v9.2+: Target path in which store all data files.
- targetLogFilePath: System.String
  - Supported in v5.0+
      v5.0-v9.1: The target path to store all log files.
      v9.2+: Target path in which store all log files.
- recoveryPoint: MssqlRecoveryPointInput
  - Required. Supported in v5.0+
- targetDatabaseName: System.String
  - Required. Supported in v5.0+
      Name of the new database.
- targetFilePaths: list of MssqlDbFileExportPathInputs
  - Supported in v5.0+
      One target path for each individual database file. Overrides targetDataFilePath and targetLogFilePath.
- targetInstanceId: System.String
  - Required. Supported in v5.0+
      ID of the Microsoft SQL instance for the new database.
