### UnmanagedObjectsInput
Input to query unmanaged objects.

- clusterUuid: System.String
  - Workload cluster UUID.
- name: System.String
  - Object name.
- objectId: System.String
  - Object Id.
- objectTypes: a list of ManagedObjectTypes
  - Object types to filter.
- retentionSlaDomainIds: a list of System.Strings
  - Retention SLAs to filter.
- sortParam: UnmanagedObjectsSortParam
  - Sorting Parameters.
- unmanagedStatuses: a list of UnmanagedObjectAvailabilityFilters
  - Unmanaged statuses to filter.
