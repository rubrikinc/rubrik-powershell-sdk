### SapHanaDatabaseInfoObject
Additional information about backint and database configuration.

- databaseType: System.String
  - Database type (SYSTEM / TENANT).
- status: System.String
  - Database status.
- backintPath: System.String
  - Path to the backint agent.
- paramFilePath: System.String
  - Path to the parameter File for the database.
- numChannels: System.Int32
  - Number of channels that the backint agent is using.
- approxDbSizeInMb: System.Int64
  - Approximate size of the database in Megabytes.
- logBackupIntervalSecs: System.Int32
  - Time interval in seconds in which the log backup will be triggered.
- restoreConfiguredSrcDatabaseId: System.String
  - CDM ID of the database from which system-copy has been configured.
- logMode: System.String
  - SAP HANA log mode (overwrite / normal).
