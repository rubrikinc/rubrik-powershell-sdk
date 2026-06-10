### SnappablesWithLegalHoldSnapshotsInput
Input to query workloads with legal hold snapshots.

- clusterUuid: System.String
  - Rubrik cluster UUID. Omit for RSC native snapshots.
- filterParams: list of LegalHoldQueryFilters
  - Filter parameters list.
- sortParam: LegalHoldSortParam
  - Sorting parameters.
