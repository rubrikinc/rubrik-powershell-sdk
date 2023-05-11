### SapHanaDatabaseInfoObject
Additional information about backint and database configuration.

- approxDbSizeInMb: System.Int64
  - Approximate size of the database in Megabytes.
- backintPath: System.String
  - Path to the backint agent.
- databaseType: System.String
  - Database type (SYSTEM / TENANT).
- logBackupIntervalSecs: System.Int32
  - Time interval in seconds in which the log backup will be triggered.
- logMode: System.String
  - SAP HANA log mode (overwrite / normal).
- numChannels: System.Int32
  - Number of channels that the backint agent is using.
- paramFilePath: System.String
  - Path to the parameter File for the database.
- restoreConfiguredSrcDatabaseId: System.String
  - CDM ID of the database from which system-copy has been configured.
- status: System.String
  - Database status.
