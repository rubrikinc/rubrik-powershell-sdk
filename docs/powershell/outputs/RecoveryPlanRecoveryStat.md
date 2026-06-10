### RecoveryPlanRecoveryStat
Aggregate recovery execution statistics for a single recovery plan,
grouped by recovery type. Although stats are served at the plan level,
each entry represents one recovery type's counts (e.g., FAILOVER vs
TEST_FAILOVER) within that plan, because different recovery types need
separate counts.

- totalRecoveryCount: System.Int64
  - Total number of recoveries performed.
- totalSuccessfulRecoveryCount: System.Int64
  - Total number of successful recoveries.
- totalFailedRecoveryCount: System.Int64
  - Total number of failed recoveries.
- recoveryPlanType: RecoveryPlanType
  - Type of the recovery plan.
- recoveryType: RecoveryType
  - Type of recovery.
