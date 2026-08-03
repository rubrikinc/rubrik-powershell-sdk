### ListSourceRecoverySpecsReq
Request for retrieving source recovery specifications for the failback scenario.
This is used to get recovery specs for workloads that need to be failed back
from a disaster recovery site to their original source location.

- workloadRecoveryPoints: list of WorkloadRecoveryPoints
  - Workload and corresponding recovery point information.
- recoveryPlanId: System.String
  - Recovery plan ID.
- recoveryType: RecoveryType
  - Recovery type.
