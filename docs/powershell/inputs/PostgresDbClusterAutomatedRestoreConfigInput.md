### PostgresDbClusterAutomatedRestoreConfigInput
Supported in v9.4+
PostgreSQL database cluster restore configuration.

- restoreInfo: RestoreInputInput
  - Required. Supported in v9.4+
v9.4: Specifies the input requied to peform the restore for the given postgres database cluster.
v9.5+: Specifies the input required to perform the restore for the given PostgreSQL database cluster.
- nodeInfo: RestoreCDMNodeInputInput
  - Supported in v9.4+
Specifies the preferred CDM Node input for restore.
- postgresRestoreSettings: PostgresRestoreSettingsInput
  - Supported in v9.4+
v9.4-v9.5: Configuration to customize the PostgreSQL database cluster restore.
v9.6: Restore settings for single-host restores. Ignored when multiPostgresRestoreSettings is set.
- multiPostgresRestoreSettings: list of PerObjectPostgresRestoreSettingsInputs
  - Per-host restore settings. Required for multi-host targets; takes precedence over postgresRestoreSettings. Must list every entry in hostRestoreTargets exactly once.
