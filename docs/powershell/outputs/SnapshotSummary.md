### SnapshotSummary
Supported in v5.2+

- date: DateTime
  - Required. Supported in v5.2+
  Time at which the snapshot was taken.
- id: System.String
  - Required. Supported in v5.2+
  ID of the snapshot.
- isCustomRetentionApplied: System.Boolean
  - Required. Supported in v5.2+
  A Boolean value that indicates whether custom retention is applied to the specified snapshot. Value is true when custom retention is applied to the snapshot.
- isRetentionLockApplied: System.Boolean
  - Required. Supported in v5.2+
  Indicates whether the snapshot is protected by a Retention Locked SLA Domain.
- snapshotRetentionInfo: SnapshotRetentionInfo
  - Required. Supported in v5.2+
  Retention information for snapshots at the local, archival, and replication locations.
- snapshotType: UnmanagedSnapshotType
  - Required. Supported in v5.2+
