### GetMissedMssqlDbSnapshotsInput
Input for getting missed snapshots of a SQL Server database.

- afterTime: DateTime
  - Filter snapshots to those missed on or after this time. The date-time string should be in ISO8601 format, such as "2016-01-01T01:23:45.678".
- beforeTime: DateTime
  - Filter snapshots to those missed on or before this time. The date-time string should be in ISO8601 format, such as "2016-01-01T01:23:45.678".
- id: System.String
  - Required. ID of the Microsoft SQL database.
