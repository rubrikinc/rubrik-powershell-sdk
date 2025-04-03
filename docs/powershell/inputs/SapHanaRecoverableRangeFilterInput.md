### SapHanaRecoverableRangeFilterInput
Input for filtering SAP HANA recoverable ranges.

- clusterUuid: list of System.Strings
  - Filter by cluster UUID.
- databaseId: list of System.Strings
  - Filter by SAP HANA database ID.
- fromTime: DateTime
  - Filter the SAP HANA recoverable range starting after the specified time.
- toTime: DateTime
  - Filter the SAP HANA recoverable range ending before the specified time.
- isArchived: System.Boolean
  - Filter by archival status of the SAP HANA recoverable range. By default archived recoverable ranges are excluded.
- startBeforeTime: DateTime
  - Filter the SAP HANA recoverable range starting before the specified time.
- endAfterTime: DateTime
  - Filter the SAP HANA recoverable range ending after the specified time.
