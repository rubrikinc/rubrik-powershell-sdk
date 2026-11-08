### WorkloadSnapshotInput
WorkloadSnapshot pairs a workload ID with the snapshot to use for
recovery. snapshot_id may be empty if no snapshot is selected or available.

- workloadId: System.String
  - Workload (managed object) ID.
- snapshotId: System.String
  - Snapshot ID to restore from. Empty if no specific snapshot is selected.
