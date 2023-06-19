### SapHanaRecoverableRangeFilterInput
Input for filtering SAP HANA recoverable ranges.

- clusterUuid: list of System.Strings
  - Filter by cluster UUID.
- databaseId: list of System.Strings
  - Filter by SAP HANA database ID.
- fromTime: DateTime
  - Filter by start time for SAP HANA recoverable range.
- toTime: DateTime
  - Filter by end time for the SAP HANA recoverable range.
- isArchived: System.Boolean
  - Filter by archival status of the SAP HANA recoverable range. By default archived recoverable ranges are excluded.
