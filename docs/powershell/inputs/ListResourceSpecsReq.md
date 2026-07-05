### ListResourceSpecsReq
Request for retrieving resource specifications for a particular Recovery Plan or recovery.

- workloadRecoveryPoints: list of WorkloadRecoveryPoints
  - Recovery point information for each workload.
- recoveryId: System.String
  - Recovery ID. If passed, it takes precedence over Recovery Plan ID.
- recoveryPlanId: System.String
  - Recovery Plan ID.
