### SapHanaAppMetadata
SAP HANA workload related app metadata for a snapshot.

- backupId: System.Int64
  - The SAP HANA backup ID for data backup.
- snapshotType: System.String
  - Snapshot type: Full/Incremental/Differential.
- sapHanaStartTime: DateTime
  - Start time for the backup in DB.
- sapHanaEndTime: DateTime
  - End time for the backup in DB.
- rubrikSnapshotStartTime: DateTime
  - Start time for the backup in Rubrik.
- rubrikSnapshotEndTime: DateTime
  - End time for the backup in Rubrik.
- backupPrefix: System.String
  - Backup prefix of data backup.
- baseFullSnapshotId: System.String
  - SnapshotId of the base full backup.
- baseBackupId: System.Int64
  - Base backup ID for the data backup. For incremental backup, this ID is the previous incremental backup ID or the full backup ID.
- isExternalBackup: System.Boolean
  - Specifies whether the backup was triggered by Rubrik or by an external agent.
- isRubrikTriggeredOnDemandBackup: System.Boolean
  - Specifies whether the backups is initiated by Rubrik and is on-demand.
- files: list of SapHanaDataBackupFiles
  - Files for the data backup.
