### ExportExchangeDbJobConfigInput
Configuration for an Exchange database export job.

- targetHostId: System.String
  - Required. ID of the Exchange host that will receive the exported database.
- targetLogFolderPath: System.String
  - Optional absolute directory on the target Exchange host for the transaction log files. Defaults to the source database log directory when omitted.
- snapshotId: System.String
  - Required. ID of the snapshot to export. Must belong to the source Exchange database identified in the request path.
- targetDatabaseName: System.String
  - Required. Name of the database to create on the target Exchange host.
- targetEdbFilePath: System.String
  - Optional absolute directory on the target Exchange host where the database (EDB) file is placed. Defaults to the source database EDB directory when omitted.
