### MssqlLogShippingCreateConfigInput
Supported in v5.0+

- maxDataStreams: System.Int32
  - Supported in v5.0+
      Maximum number of parallel data streams that can be used to copy data to the target system.
- targetDataFilePath: System.String
  - Supported in v5.0+
      v5.0-v9.1: The path to the default target location for data file storage.
      v9.2: Target path in which store all data files.
- targetLogFilePath: System.String
  - Supported in v5.0+
      v5.0-v9.1: The path to the location of the log files.
      v9.2: Target path in which store all log files.
- mssqlLogShippingTargetStateOptions: MssqlLogShippingTargetStateOptionsInput
  - State options of a SQL Server log shipping target.
- targetDatabaseName: System.String
  - Required. Supported in v5.0+
      The name of the secondary database.
- targetFilePaths: list of MssqlDbFileExportPathInputs
  - Supported in v5.0+
      Array of database file storage paths. Each path is the target storage location for a database file. Values in this array override the values in targetDataFilePath and targetLogFilePath for the specified database files.
- targetInstanceId: System.String
  - Required. Supported in v5.0+
      The ID of the SQL Server instance that hosts the secondary database.
