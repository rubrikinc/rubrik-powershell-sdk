### RecoveryPlanBasicInfo
Basic information about the recovery plans.

- id: System.String
  - Recovery plan identifier.
- name: System.String
  - Recovery plan name.
- version: System.Int64
  - Version of the recovery plan.
- recoveryPlanType: RecoveryPlanType
  - Recovery plan type.
- workloadType: ManagedObjectType
  - Type of workloads for which this recovery plan is defined.
- recoveryPlanStatus: RecoveryPlanStatus
  - Current status of the recovery plan.
- sourceLocation: RecoveryPlanLocation
  - Source location information.
- targetLocation: RecoveryPlanLocation
  - Target location information.
- recoveryPlanStats: RecoveryPlanStats
  - Recovery statistics for this recovery plan.
- targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo
  - Target consistency information for this recovery plan.
- recoverySchedule: RecoverySchedule
  - Recovery schedule associated with this recovery plan.
- latestRecovery: Recovery
  - The latest recovery for this recovery plan.
