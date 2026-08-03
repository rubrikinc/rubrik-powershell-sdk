### SnapshotQueryFilterInput
Filter snapshots.

- field: SnapshotQueryFilterField
  - Type of filter.
- text: System.String
  - Additional Information for the filter type.
- typeFilters: list of SnapshotTypeEnums
  - Snapshot types to be filtered.
- shouldFetchLinked: System.Boolean
  - Snapshots from linked workloads.
- textList: list of System.Strings
  - List of search texts for the filter type.
- time: DateTime
  - Time should be used only with filters where we want to pass a single
timestamp. Cases can be BEFORE, AFTER or time equality filters.
- customizationFilters: list of SnapshotCustomizations
  - Filter snapshot customizations.
