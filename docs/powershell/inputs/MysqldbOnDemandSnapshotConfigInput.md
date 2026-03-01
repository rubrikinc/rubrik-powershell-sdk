### MysqldbOnDemandSnapshotConfigInput
Supported in v9.5+

- baseOnDemandSnapshotConfig: BaseOnDemandSnapshotConfigInput
- snapshotType: MysqldbOnDemandSnapshotConfigSnapshotType
  - Supported in v9.5+
Type of snapshot to perform for MySQL database instance.
- FULL: Complete backup of the database.
- INCREMENTAL: Backup of data changed since last backup.
- LOG: Backup of binary logs only.
