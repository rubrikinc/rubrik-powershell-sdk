### SapHanaAppMetadata
SAP HANA workload related app metadata for a snapshot.

- backupId: System.Int64
  - The SAP HANA backup ID for data backup.
- backupPrefix: System.String
  - Backup prefix of data backup.
- baseBackupId: System.Int64
  - Base backup ID for the data backup. For incremental backup, this ID is the previous incremental backup ID or the full backup ID.
- baseFullSnapshotId: System.String
  - SnapshotId of the base full backup.
- files: a list of SapHanaDataBackupFiles
  - Files for the data backup.
- isExternalBackup: System.Boolean
  - Specifies whether the backup was triggered by Rubrik or by an external agent.
- isRubrikTriggeredOnDemandBackup: System.Boolean
  - Specifies whether the backups is initiated by Rubrik and is on-demand.
- rubrikSnapshotEndTime: DateTime
  - End time for the backup in Rubrik.
- rubrikSnapshotStartTime: DateTime
  - Start time for the backup in Rubrik.
- sapHanaEndTime: DateTime
  - End time for the backup in DB.
- sapHanaStartTime: DateTime
  - Start time for the backup in DB.
- snapshotType: System.String
  - Snapshot type: Full/Incremental/Differential.
