### SapHanaOnDemandBackupConfigInput
Configuration for creating an on-demand SAP HANA database backup.

- backupType: SapHanaOnDemandBackupConfigBackupType
  - Supported in v9.4+
      Type of backup to perform for SAP HANA database.
      - FULL: Complete backup of the database.
      - DIFFERENTIAL: Backup of data changed since last full backup.
      - INCREMENTAL: Backup of data changed since last backup 
      (full/differential/incremental).
- baseOnDemandSnapshotConfig: BaseOnDemandSnapshotConfigInput
  - Configuration for the on-demand snapshot.
