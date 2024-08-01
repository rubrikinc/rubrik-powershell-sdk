### UnmanagedObjectsInput
Input to query unmanaged objects.

- clusterUuid: System.String
  - Workload cluster UUID.
- name: System.String
  - Object name.
- unmanagedStatuses: list of UnmanagedObjectAvailabilityFilters
  - Unmanaged statuses to filter.
- objectTypes: list of ManagedObjectTypes
  - Object types to filter.
- retentionSlaDomainIds: list of System.Strings
  - Retention SLAs to filter.
- sortParam: UnmanagedObjectsSortParam
  - Sorting Parameters.
- objectId: System.String
  - Object Id.
- regions: list of WorkloadRegionInputs
  - Regions to filter.
- cloudAccountIds: list of System.Strings
  - Cloud account IDs to filter.
- managedBy: CloudVendor
  - Managed by to filter.
