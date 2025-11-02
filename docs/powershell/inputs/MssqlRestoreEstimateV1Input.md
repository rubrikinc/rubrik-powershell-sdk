### MssqlRestoreEstimateV1Input
Input for getting a byte size estimate for a restore or export.

- id: System.String
  - Required. ID of the Microsoft SQL database.
- lsn: System.String
  - LSN to recover to. This value or the LSN are required.
- recoveryForkGuid: System.String
  - Recovery fork GUID of LSN to recover to. Meaningful only when lsn is specified.
- time: DateTime
  - Time, in ISO8601 date-time format, to recover to. For example, "2016-01-01T01:23:45.678". This value or the LSN are required.
