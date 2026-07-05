### LegalHoldQueryFilter
Legal Hold query filter.

- filterField: LegalHoldQueryFilterField
  - Filters for legal hold query.
- beforeTime: DateTime
  - Filter snapshots before the specific time.
- afterTime: DateTime
  - Filter snapshots after the specific time.
- snappableName: System.String
  - Workload name.
- snappableTypes: list of ManagedObjectTypes
  - Workload types.
- snapshotTypes: list of SnapshotTypeEnums
  - Snapshot types.
- snapshotCustomizations: list of SnapshotCustomizations
- cloudVendor: CloudVendor
  - Cloud vendor to filter by (AWS, Azure, or GCP).
- cloudRegions: list of System.Strings
  - Cloud regions to filter by.
- cloudAccountIds: list of System.Strings
  - Cloud account IDs to filter by. Only valid for RSC native legal holds. These are the Rubrik Security Cloud IDs of cloud-account hierarchy nodes, not CSP-native account numbers.
