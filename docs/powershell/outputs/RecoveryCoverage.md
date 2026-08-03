### RecoveryCoverage
Recovery coverage for a single workload on one cluster.

- recoveryPoint: DateTime
  - The workload's recovery point on this cluster context.
- recoverableRanges: list of RecoverableRanges
  - CDP recoverable time ranges on this cluster.
- missedRecoverableRanges: list of RecoverableRanges
  - CDP missed recoverable time ranges on this cluster.
- recoveryState: RecoveryState
  - CDP state on this cluster.
