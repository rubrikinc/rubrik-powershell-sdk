### MssqlLogShippingApplyLogsInput
Configuration parameters for applying pending transaction logs to a SQL Server log shipping secondary database.

- shouldDisconnectStandbyUsers: System.Boolean
  - Whether to automatically disconnect users from a secondary database in Standby mode while pending transaction logs are applied. If this value is false and users remain connected, then the restore operation will fail. If the secondary database is in Restoring mode, this value is ignored.
