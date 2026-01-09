### RecoverToPointInTimeDb2DbConfigInput
Supported in v9.5+

- tmpDirectoryPath: System.String
  - Required. Supported in v9.5+
The temporary directory path where Db2 recovery scripts will be created and where logs will be stored during the recovery process.
- sessions: System.Int32
  - Supported in v9.5+
Number of parallel sessions to use for the restore operation.
- sourceDbId: System.String
  - Required. Supported in v9.5+
The database ID that you want to recover. The source instance and host information will be derived from this database ID.
- targetInstanceId: System.String
  - Supported in v9.5+
The ID of the target Db2 instance where the recovery will be performed. If not specified, recovery will be performed on the source instance. The target host information will be derived from the instance configuration.
- remoteLocationId: System.String
  - Supported in v9.5+
The location from which to download the backup to the source cluster, if the backup is not present on the local cluster.
- recoveryPoint: DateTime
  - Required. Supported in v9.5+
The time to which to recover the Db2 database.
- targetDbName: System.String
  - Required. Supported in v9.5+
The name of the target database to be created or to which to restore backups. The name must be eight or fewer characters.
- targetDatabaseDirectoryPath: System.String
  - Supported in v9.5+
This is required when creating a new database and is optional during recovery to existing database.
