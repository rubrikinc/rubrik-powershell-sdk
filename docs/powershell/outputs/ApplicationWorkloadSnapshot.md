### ApplicationWorkloadSnapshot
ApplicationWorkloadSnapshot is a single workload's
optimized snapshot result within an application.

- workloadId: System.String
  - Workload ID.
- snapshot: ApplicationSnapshotInfo
  - Optimized snapshot for this workload. Nullable: a workload
is included in the parent ApplicationWorkloadTypeSnapshots
even when it has no snapshot in the requested time/quality
window, so the UI can show all workloads (with empty
snapshot details) instead of an apparent gap in the list.
- objectName: System.String
  - Name of the workload object.
