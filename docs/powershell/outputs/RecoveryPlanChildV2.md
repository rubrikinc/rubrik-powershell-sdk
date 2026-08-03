### RecoveryPlanChildV2
Recovery plan child.

- id: System.String
  - Workload identifier.
- workloadType: ManagedObjectType
  - Workload type.
- localRpoLagInfo: RpoLagInfoV2
  - Local RPO lag information for this workload.
- remoteRpoLagInfo: RpoLagInfoV2
  - Remote RPO lag information for this workload.
- localRecoveryCoverage: RecoveryCoverage
  - Recovery coverage on the source cluster including recovery points, recoverable ranges, and CDP state.
- remoteRecoveryCoverage: RecoveryCoverage
  - Recovery coverage on the target cluster including recovery points, recoverable ranges, and CDP state.
- resourceSpec: WorkloadResourceSpec
  - Resource specification for this child workload.
