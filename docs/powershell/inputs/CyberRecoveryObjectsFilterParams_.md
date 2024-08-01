### CyberRecoveryObjectsFilterParams
Filter parameters for cyber recovery objects.

- name: System.String
  - Filter by name.
- objectTypes: list of ManagedObjectTypes
  - Filter by object types.
- recoveryPlanNames: list of System.Strings
  - Filter by recovery plan names.
- clusterUuids: list of System.Strings
  - Filter by cluster UUIDs.
- retentionSlaDomainIds: list of System.Strings
  - Filter by retention SLA Domain IDs.
- statuses: list of WorkloadLastFailoverStatuss
  - Filter by status.
- snappableStatus: WorkloadStatus
  - Filter by workload status.
- shouldIncludeReplica: System.Boolean
  - Filter by the should include replica flag.
