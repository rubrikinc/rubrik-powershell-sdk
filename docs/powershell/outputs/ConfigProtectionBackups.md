### ConfigProtectionBackups
List of configuration backups of a Rubrik cluster.

- clusterUuid: System.String
  - UUID of the source cluster.
- clusterName: System.String
  - Name of the source cluster.
- replicationTargetUuid: System.String
  - UUID of the replication cluster where backup file is stored.
- replicationTargetName: System.String
  - Name of the replication cluster where backup file is stored.
- backupFileName: System.String
  - Name of the configuration backup file.
- backupTimestamp: DateTime
  - Date and time when the configuration backup was taken.
- backupClusterVersion: System.String
  - Rubrik CDM version of the source cluster at the time of backup.
- backupSizeInBytes: System.Int64
  - Size of the configuration backup file in bytes.
- uploadLocationType: UploadLocationType
  - Upload location type.
