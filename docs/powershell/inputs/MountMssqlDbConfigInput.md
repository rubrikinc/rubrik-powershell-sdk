### MountMssqlDbConfigInput
Supported in v5.0+

- mountedDatabaseName: System.String
  - Required. Supported in v5.0+
Name to assign to the mounted database.
- recoveryPoint: MssqlRecoveryPointInput
  - Required. Supported in v5.0+
- targetInstanceId: System.String
  - Supported in v5.0+
ID of the SQL Server instance to mount the database on. For availability source databases, this must be specified. When unspecified for non-availability source databases, the source SQL Server instance is used.
- recoveryModel: MssqlDatabaseRecoveryModel
  - Supported in v5.1+
Recovery model to assign to the mounted database. If not specified, then assigns the recovery model of the mounted database to the recovery model of the source database.
