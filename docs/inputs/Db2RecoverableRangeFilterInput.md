### Db2RecoverableRangeFilterInput
Filter Db2 recoverable ranges.

- clusterUuid: a list of System.Strings
  - The cluster uuid for which db2 recoverable ranges are filtered.
- databaseId: a list of System.Strings
  - The db2 database ID for which db2 recoverable ranges are filtered.
- fromTime: DateTime
  - Start time for db2 recoverable range.
- isArchived: System.Boolean
  - Filter by archival status of the Db2 recoverable range. By default archived recoverable ranges are excluded.
- toTime: DateTime
  - End time for the db2 recoverable range.
