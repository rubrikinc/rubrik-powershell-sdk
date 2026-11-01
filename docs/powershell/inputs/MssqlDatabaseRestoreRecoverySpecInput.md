### MssqlDatabaseRestoreRecoverySpecInput
Recovery specification for restoring a SQL Server database.

- targetInstanceId: System.String
  - ID of the SQL Server instance to recover the database to. A recovery
specification without a target instance is rejected.
- targetDataFilePath: System.String
  - Directory for the recovered data files. Empty means the source path.
- targetLogFilePath: System.String
  - Directory for the recovered log files. Empty means the source path.
