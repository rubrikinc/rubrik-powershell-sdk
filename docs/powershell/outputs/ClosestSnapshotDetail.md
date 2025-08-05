### ClosestSnapshotDetail
Snapshot details.

- id: System.String
  - The snapshot ID.
- date: DateTime
  - The snapshot creation time.
- snapshotDetail: GenericSnapshot
  - The workload snapshot details.
- isAnomaly: System.Boolean
  - Specifies whether the snapshot is anomalous or not.
- isQuarantineProcessing: System.Boolean
  - Specifies whether the snapshot is being processed to determine its quarantine state.
- isQuarantined: System.Boolean
  - Specifies whether the snapshot is quarantined or not.
