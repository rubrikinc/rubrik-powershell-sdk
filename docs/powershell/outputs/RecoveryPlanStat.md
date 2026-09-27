### RecoveryPlanStat
Statistics for recovery plans of a specific type covering the workload.

- recoveryPlanType: RecoveryPlanType
  - Type of recovery plan (Failover, Disaster Recovery, Cyber Recovery, etc.).
- totalRecoveryPlans: System.Int32
  - Total number of recovery plans of this type protecting the workload.
- numRecoveryPlansSucceededLastQuarter: System.Int32
  - Number of recovery plans that succeeded in the last quarter.
- numRecoveryPlansFailedLastQuarter: System.Int32
  - Number of recovery plans that failed in the last quarter.
- numRecoveryPlansWithTestScheduled: System.Int32
  - Number of recovery plans with scheduled tests.
- numRecoveryPlansWithConfigError: System.Int32
  - Number of recovery plans with configuration errors.
