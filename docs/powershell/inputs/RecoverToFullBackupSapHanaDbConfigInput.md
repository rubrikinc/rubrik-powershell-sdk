### RecoverToFullBackupSapHanaDbConfigInput


- remoteLocationId: System.String
  - The location from where the full backup has to be downloaded back to the source cluster, if it is not present on the local cluster.
- dbId: System.String
  - Required. The database ID that you want to recover.
- fullSnapshotId: System.String
  - Required. The ID of the full backup to which the database has to be recovered.
- sourceDbConfig: SapHanaRestoreSourceConfigInput
  - 
