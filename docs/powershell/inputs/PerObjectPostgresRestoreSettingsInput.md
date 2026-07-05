### PerObjectPostgresRestoreSettingsInput
Supported in v9.6+
Restore settings for one (hostId, portNumber) target.

- portNumber: System.Int32
  - Required. Supported in v9.6+
PostgreSQL port on the target host.
- restoreSettings: PostgresRestoreSettingsInput
  - Required. Supported in v9.6+
Restore settings applied to this target.
- hostId: System.String
  - Required. Supported in v9.6+
Managed ID of the target host.
