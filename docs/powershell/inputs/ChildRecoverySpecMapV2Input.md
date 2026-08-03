### ChildRecoverySpecMapV2Input
Child recovery specification mapping for workload recovery.

- workloadRecoverySpec: WorkloadRecoverySpecInput
  - Workload recovery specification containing the recovery configuration.
- recoveryPoint: System.Int64
  - Recovery point timestamp for the workload.
- workloadId: System.String
  - Unique identifier for the workload.
- snapshotId: System.String
  - Snapshot identifier.
- postFailoverSlaId: System.String
  - Post-failover SLA Domain identifier.
- bootPriority: System.Int32
  - Boot priority order for the workload during recovery.
