### SnappablesWithLegalHoldSnapshotsInput
Input to query workloads with legal hold snapshots.

- clusterUuid: System.String
  - Rubrik cluster UUID. Omit for RSC native snapshots.
- filterParams: list of LegalHoldQueryFilters
  - Filter parameters list.
- sortParam: LegalHoldSortParam
  - Sorting parameters.
- legalHoldStateFilter: list of LegalHoldStateFilterValues
  - Legal hold state filter. Multiple values OR together.
Omit to return workloads matching the default query behavior.
- backupCopyType: BackupCopyType
  - Filter by backup copy type (PRIMARY = source, REPLICA = replicated).
Omit to return both.
