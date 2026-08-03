### UnsupportedWorkloadTypeInfo
UnsupportedWorkloadTypeInfo summarises one RU-unsupported workload
type present on the Rubrik cluster: how many of its workload objects are
currently paused vs unpaused.

- workloadType: System.String
  - Internal workload type identifier (for example "ManagedVolume").
- displayName: System.String
  - Customer-facing display name for the workload type (for example
"Managed Volume").
- pausedCount: System.Int32
  - Number of workload objects of this type that are currently paused.
- nonPausedCount: System.Int32
  - Number of workload objects of this type that are not paused.
