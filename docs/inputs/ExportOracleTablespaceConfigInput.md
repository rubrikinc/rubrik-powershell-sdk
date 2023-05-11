### ExportOracleTablespaceConfigInput
Supported in v5.0+

- auxiliaryDestinationPath: System.String
  - Required. Supported in v5.0+
      The full path to the directory on the source host where the auxiliary database files will be created.
- exposeAllLogs: System.Boolean
  - Supported in v5.2+
      Expose all logs that were backed up between the selected recovery point and the latest log backup.
- recoveryPoint: OracleRecoveryPointInput
  - Required. Supported in v5.0+
      Snapshot ID or timestamp for which the export is done.
- tablespaceName: System.String
  - Required. Supported in v5.0+
      Name of the tablespace to be exported from the existing database snapshot.
