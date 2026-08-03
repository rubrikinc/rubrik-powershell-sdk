### WorkloadLastRecovery
A current workload's last recovery within a specific recovery plan.

- workloadId: System.String
  - Unique identifier of the workload.
- lastRecoveryOutcome: RecoveryOutcome
  - Outcome of the last recovery; UNKNOWN when never recovered.
- lastRecoverySnapshotTime: DateTime
  - Snapshot time of the last recovery; absent when never recovered.
