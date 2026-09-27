### WorkloadRecoveryInfoV2
Recovery information for a workload.

- workloadId: System.String
  - Workload ID.
- workloadRecoveryStatus: WorkloadRecoveryStatusV2
  - Workload recovery status.
- workloadSizeInKbs: System.Int64
  - Workload size in kilobytes.
- workloadName: System.String
  - Workload name.
- workloadRecoveryId: System.String
  - Taskchain ID or CDM job ID of the recovery operation for this
workload.
- workloadRecoveryOutcome: RecoveryOutcome
  - Workload recovery outcome.
- jobProgressPercentage: System.Single
  - Progress percentage of the recovery job for this workload, from 0 to
100. Absent when the underlying job reports no progress, and for data
transfer types that do not report per-workload progress.
