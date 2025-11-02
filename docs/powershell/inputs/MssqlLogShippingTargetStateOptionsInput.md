### MssqlLogShippingTargetStateOptionsInput
Supported in v5.0+

- shouldDisconnectStandbyUsers: System.Boolean
  - Supported in v5.0+
v5.0-v5.2: Whether to automatically disconnect users from a secondary database in Standby mode when a restore operation is performed. If this value is false and users remain connected, then any scheduled restore operations will fail. If the "state" field is `RESTORING`, this value can be omitted and will otherwise be ignored.
v5.3+: Specifies whether to automatically disconnect users from a secondary database in standby mode when a restore operation is performed. If this value is set to false and users remain connected, any scheduled restore operations fail. If the "state" field is `RESTORING`, this value can be omitted and is ignored.
- state: MssqlLogShippingOkState
  - Required. Supported in v5.0+
