### RecoverToEndOfBackupDb2DbConfigInput


- tmpDirectoryPath: System.String
  - Required. The temporary directory path where Db2 recovery scripts will be created and where logs will be stored during the recovery process.
- sessions: System.Int32
  - Number of parallel sessions to use for the restore operation.
- sourceDbId: System.String
  - Required. The database ID that you want to recover. The source instance and host information will be derived from this database ID.
- targetInstanceId: System.String
  - The ID of the target Db2 instance where the recovery will be performed. If not specified, recovery will be performed on the source instance. The target host information will be derived from the instance configuration.
- remoteLocationId: System.String
  - The location from which to download the backup to the source cluster, if the backup is not present on the local cluster.
- snapshotId: System.String
  - Required. The ID of the backup snapshot to which to recover the database.
- targetDbName: System.String
  - Required. The name of the target database to be created or to which to restore backups. The name must be eight or fewer characters.
- targetDatabaseDirectoryPath: System.String
  - This is required when creating a new database and is optional during recovery to existing database.
