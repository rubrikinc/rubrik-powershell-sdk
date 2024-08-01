### Db2LogSnapshotFilterInput
Filter Db2 log snapshots.

- workloadId: list of System.Strings
  - The workload ID for which log snapshots are filtered.
- clusterUuid: list of System.Strings
  - The cluster uuid for which log snapshots are filtered.
- fromTime: DateTime
  - Start time for the log snapshots connection.
- toTime: DateTime
  - End time for the log snapshots connection.
- isArchived: System.Boolean
  - Filter by the archival status of log snapshots. By default, archived snapshots are excluded.
