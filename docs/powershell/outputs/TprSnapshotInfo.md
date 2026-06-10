### TprSnapshotInfo
Per-snapshot information for TPR request details.

- snapshotId: System.String
  - ID of the snapshot.
- isOnDemandSnapshot: System.Boolean
  - Whether the snapshot is an on-demand snapshot.
- isDownloadedSnapshot: System.Boolean
  - Whether the snapshot is a downloaded snapshot.
- isCustomRetentionApplied: System.Boolean
  - Whether custom retention is applied to this snapshot.
- objectId: System.String
  - ID of the protected object this snapshot belongs to.
- snapshotDate: DateTime
  - Date and time when the snapshot was taken.
- perLocationSnapshotInfos: list of TprPerLocationSnapshotInfos
  - Per-location snapshot information such as expiration time.
