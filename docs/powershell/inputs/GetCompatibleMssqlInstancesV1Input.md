### GetCompatibleMssqlInstancesV1Input
Input for getting compatible instances for the recovery of a SQL Server database.

- id: System.String
  - Required. ID of the Microsoft SQL database.
- recoveryTime: DateTime
  - Time, in ISO8601 format, to recover to. For example "2016-01-01T01:23:45.678Z". If this is not specified, the latest recoverable time is used.
- recoveryType: V1GetCompatibleMssqlInstancesV1RequestRecoveryType
  - Required. Recovery type.
