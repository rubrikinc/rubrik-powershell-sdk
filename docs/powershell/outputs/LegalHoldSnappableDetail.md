### LegalHoldSnappableDetail
Legal hold details of the workload.

- name: System.String
  - Workload name.
- id: System.String
  - ID.
- snappableType: ManagedObjectType
  - Workload type.
- snapshotDetails: list of LegalHoldSnapshotDetails
  - Snapshot details.
- snapshotCount: System.Int32
  - Number of snapshots on legal hold.
- physicalLocation: list of LocationPathPoints
  - Physical path to this workload.
