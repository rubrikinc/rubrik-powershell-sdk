### SnapshotQueryFilterInput
Filter snapshots.

- customizationFilters: a list of SnapshotCustomizations
  - Filter snapshot customizations.
- field: SnapshotQueryFilterField
  - Type of filter.
- shouldFetchLinked: System.Boolean
  - Snapshots from linked workloads.
- text: System.String
  - Additional Information for the filter type.
- textList: a list of System.Strings
  - List of search texts for the filter type.
- time: DateTime
  - None
- typeFilters: a list of SnapshotTypeEnums
  - Snapshot types to be filtered.
