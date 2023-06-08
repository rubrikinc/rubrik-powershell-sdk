### MssqlLogShippingCreateConfigInput
Supported in v5.0+

- maxDataStreams: System.Int32
  - Supported in v5.0+
      Maximum number of parallel data streams that can be used to copy data to the target system.
- targetDataFilePath: System.String
  - Supported in v5.0+
      The path to the default target location for data file storage.
- targetFilePaths: list of MssqlDbFileExportPathInputs
  - Supported in v5.0+
      Array of database file storage paths. Each path is the target storage location for a database file. Values in this array override the values in targetDataFilePath and targetLogFilePath for the specified database files.
- targetLogFilePath: System.String
  - Supported in v5.0+
      The path to the location of the log files.
- mssqlLogShippingTargetStateOptions: MssqlLogShippingTargetStateOptionsInput
  - State options of a SQL Server log shipping target.
- targetDatabaseName: System.String
  - Required. Supported in v5.0+
      The name of the secondary database.
- targetInstanceId: System.String
  - Required. Supported in v5.0+
      The ID of the SQL Server instance that hosts the secondary database.
