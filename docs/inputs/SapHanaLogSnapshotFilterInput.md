### SapHanaLogSnapshotFilterInput
Input for filtering SAP HANA log snapshots.

- clusterUuid: a list of System.Strings
  - Filter by cluster UUID.
- fromTime: DateTime
  - Filter by start time of the log snapshots.
- isArchived: System.Boolean
  - Filter by the archival status of log snapshots. By default, archived snapshots are excluded.
- toTime: DateTime
  - Filter by end time of the log snapshots.
- workloadId: a list of System.Strings
  - Filter by SAP HANA database ID.
