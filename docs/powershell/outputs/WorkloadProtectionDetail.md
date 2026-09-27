### WorkloadProtectionDetail
Protection details for a single workload including recovery plan statistics.

- workloadId: System.String
  - FID of the workload.
- recoveryPlanStatsByType: list of RecoveryPlanStats
  - Recovery plan statistics grouped by recovery plan type.
- recoveryPlans: list of RecoveryPlanBasicInfos
  - List of recovery plans protecting this workload.
- totalRecoveryCount: System.Int64
  - Total number of completed recoveries for this workload.
- recoveryCountsByType: list of WorkloadRecoveryCounts
  - Recoveries for a workload grouped by recovery type.
- lastWorkloadRecoveryInfo: LastWorkloadRecoveryInfo
  - This workload's last recovery, and its per-workload outcome.
