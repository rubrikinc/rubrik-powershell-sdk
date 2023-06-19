### Db2AppMetadata
Db2 workload related app metadata for a snapshot.

- backupId: System.String
  - Backup ID set by database.
- snapshotId: System.String
  - The ID for the backup object stored in snapshot table.
- snapshotType: Db2SnapshotType
  - Snapshot type: Full/Incremental/Differential.
- baseSnapshotId: System.String
  - Snapshot ID of the base backup.
- baseSnapshotType: Db2SnapshotType
  - Snapshot type for base back up: Full/Incremental/Differential.
- baseBackupId: System.String
  - Backup ID of the base backup.
- startTime: DateTime
  - Start time for the backup in DB.
- endTime: DateTime
  - End time for the backup in DB.
- files: list of Db2DataBackupFiles
  - List of files backed up as a part of this backup.
- isExternalBackup: System.Boolean
  - Denotes whether the backup was triggered by Rubrik or by an external agent.
- isRubrikTriggeredOnDemandBackup: System.Boolean
  - Whether the backup is triggered by Rubrik and is OnDemand.
- approximateDbSizeBytes: System.Int64
  - Approximate DB size just around the time the snapshot is taken.
- db2SnapshotMetadata: Db2WorkloadDataSnapshotMetadata
  - Snapshot metadata information specific to Db2.
