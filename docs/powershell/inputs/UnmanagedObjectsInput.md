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
- backupCopyType: BackupCopyType
  - Backup copy type to filter.
- snapshotManagementType: SnapshotManagementType
  - Snapshot management type to filter.
- hasDownloadedSnapshots: System.Boolean
  - Filter objects based on presence of downloaded snapshots. When not specified, all objects are returned. When true, only objects with downloaded snapshots are returned. When false, only objects without downloaded snapshots are returned.
- managedBy: CloudVendor
  - Managed by to filter.
