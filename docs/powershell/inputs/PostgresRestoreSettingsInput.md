### PostgresRestoreSettingsInput
Supported in v9.4+
PostgreSQL database cluster automated restore configuration.

- shouldRestoreAsReadOnly: System.Boolean
  - Specifies whether the database should be restored in read-only mode.
- systemUsername: System.String
  - Supported in v9.4+
Username for accessing the host machine.
- shouldRestoreAsReplica: System.Boolean
  - Supported in v9.4+
Specifies whether the database should be restored as a replica or the primary database cluster.
- shouldOverrideConfFiles: System.Boolean
  - Supported in v9.4+
Specifies whether RSC should override the configuration file on the host.
- dbUsername: System.String
  - PostgreSQL database role name for psql connections during restore. Use when peer authentication with ident maps requires a different DB role than the OS username.
