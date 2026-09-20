### PostgresRestoreSettingsInput
Supported in v9.4+
PostgreSQL database cluster automated restore configuration.

- shouldRestoreAsReadOnly: System.Boolean
  - Supported in v9.6+
Specifies whether the database should be restored in read-only mode.
- shouldUseCustomRestartScript: System.Boolean
  - Whether to use custom scripts for start/stop during restore. When true, customStartScriptFile and customStopScriptFile are required. customRestartScriptFile is additionally required when shouldRestoreAsReplica or shouldRestoreAsReadOnly is true. Requires the enableApiCustomRestartScripts cluster configuration to be enabled.
- systemUsername: System.String
  - Supported in v9.4+
Username for accessing the host machine.
- shouldRestoreAsReplica: System.Boolean
  - Supported in v9.4+
Specifies whether the database should be restored as a replica or the primary database cluster.
- shouldOverrideConfFiles: System.Boolean
  - Supported in v9.4+
Specifies whether RSC should override the configuration file on the host.
- customStopScriptFile: System.String
  - Absolute path on the host to the custom script to stop the PostgreSQL instance during restore. Required when shouldUseCustomRestartScript is true.
- dbUsername: System.String
  - Supported in v9.5+
PostgreSQL database role name for psql connections during restore. Use when peer authentication with ident maps requires a different DB role than the OS username.
- customRestartScriptFile: System.String
  - Absolute path on the host to the custom script to restart the PostgreSQL instance during standby restore. Required when shouldUseCustomRestartScript is true and shouldRestoreAsReplica or shouldRestoreAsReadOnly is true.
- customStartScriptFile: System.String
  - Absolute path on the host to the custom script to start the PostgreSQL instance during restore. Required when shouldUseCustomRestartScript is true.
