### PerObjectPostgresRestoreSettingsInput
Restore settings for one (hostId, portNumber) target.

- portNumber: System.Int32
  - Required. PostgreSQL port on the target host.
- restoreSettings: PostgresRestoreSettingsInput
  - Required. Restore settings applied to this target.
- hostId: System.String
  - Required. Managed ID of the target host.
