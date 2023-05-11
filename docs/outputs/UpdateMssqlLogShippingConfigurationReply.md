### UpdateMssqlLogShippingConfigurationReply
Supported in v5.3+

- links: MssqlLogShippingLinks
  - Required. Supported in v5.3+
- mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2
  - Updated detail of the log shipping configuration object.
- shouldDisconnectStandbyUsers: System.Boolean
  - Supported in v5.3+
  Specifies whether to automatically disconnect users from a secondary database in standby mode when a restore operation is performed. If this value is set to false and users remain connected, any scheduled restore operations fail. This value is returned only when the secondary database is in standby mode.
