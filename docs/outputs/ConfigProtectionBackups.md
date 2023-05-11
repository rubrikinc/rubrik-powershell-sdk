### ConfigProtectionBackups
List of configuration backups of a Rubrik cluster.

- backupClusterVersion: System.String
  - Rubrik CDM version of the source cluster at the time of backup.
- backupFileName: System.String
  - Name of the configuration backup file.
- backupSizeInBytes: System.Int64
  - Size of the configuration backup file in bytes.
- backupTimestamp: DateTime
  - Date and time when the configuration backup was taken.
- clusterName: System.String
  - Name of the source cluster.
- clusterUuid: System.String
  - UUID of the source cluster.
- replicationTargetName: System.String
  - Name of the replication cluster where backup file is stored.
- replicationTargetUuid: System.String
  - UUID of the replication cluster where backup file is stored.
- uploadLocationType: UploadLocationType
  - Upload location type.
