### RecoverToFullBackupSapHanaDbConfigInput
Supported in v9.4+

- remoteLocationId: System.String
  - Supported in v9.4+
The location from where the full backup has to be downloaded back to the source cluster, if it is not present on the local cluster.
- sourceDbConfig: SapHanaRestoreSourceConfigInput
  - Supported in v9.4+
- dbId: System.String
  - Required. Supported in v9.4+
The database ID that you want to recover.
- fullSnapshotId: System.String
  - Required. Supported in v9.4+
The ID of the full backup to which the database has to be recovered.
