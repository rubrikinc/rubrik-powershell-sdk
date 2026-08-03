### OracleUpdateInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Supported in v5.0-v5.1
ID of the SLA Domain protecting the specified Oracle object.
- hostMount: System.String
  - Supported in v5.0-v5.3
Path where the NFS share is mounted on the host.
- logBackupFrequencyInMinutes: System.Int32
  - Supported in v5.0-v5.3
Specifies an interval in minutes. This interval is the period between successive log backups.
- logRetentionHours: System.Int32
  - Supported in v5.0-v5.3
Specifies an interval in hours. Log backups are retained for the duration of the interval.
- numChannels: System.Int32
  - Supported in v5.0-v5.3
Number of channels used to backup the Oracle database.
- hostLogRetentionHours: System.Int32
  - Supported in v5.2-v5.3
Specifies an interval in hours. For Oracle archived redo log files whose nextTime is before (now - interval), the next log snapshot job will delete them from the host. Set to 0 for inheriting the value from its parent; -1 for immediate deletion; and -2 to skip log deletion.
- configuredSlaDomainIdDeprecated: System.String
  - Supported in v6.0+
ID of the SLA domain protecting the specified Oracle object. Log backup jobs are no longer scheduled if the SLA domain indicates the Oracle object is unprotected. The specified SLA domain is not used to configure the protection or retention for this Oracle object. This is a DEPRECATED field, and will be removed in later releases.
- nodeOrder: list of OracleNodeOrderInputs
  - Supported in v6.0+
Specifies an order for the RAC nodes. Automated Oracle backups use the RAC nodes in the specified order.
- shouldDistributeBackupsAutomatically: System.Boolean
  - Supported in v6.0+
Boolean value that specifies whether the Rubrik cluster should automatically distribute backups across Oracle database instances running on the RAC nodes. By default, backups are run from the first connected node in the RAC priority order.
- oracleUpdateCommon: OracleUpdateCommonInput
- primaryNode: System.String
  - Supported in v9.6+
Name of the RAC node designated as the primary backup node. REQUIRED when shouldEnableMultiNodeBackup is true.
- shouldClearExcludedDbUniqueNames: System.Boolean
  - Supported in v9.5, v9.7
v9.5: Boolean value that specifies whether to clear the stored exclude-list of Oracle database unique names for this Oracle host or RAC. When set to true, the stored exclude-list is cleared. Takes precedence over excludedDbUniqueNames when both are provided.
v9.7: Boolean value that specifies whether to clear the stored exclude-list of Oracle database unique names for this Oracle host or RAC. When set to true, the stored exclude-list is cleared. Takes precedence over excludedDbUniqueNames when both are provided.
- shouldEnableMultiNodeBackup: System.Boolean
  - Supported in v9.6+
Boolean value that specifies whether multi-node backup is enabled for this Oracle RAC. When set to true, backupNodes, primaryNode, and secondaryNodes must all be provided in the same request (pass an empty array for secondaryNodes if no secondary fallback nodes are configured). When set to false, all stored multi-node backup configuration (backupNodes, primaryNode, secondaryNodes) is cleared.
- excludedDbUniqueNames: list of System.Strings
  - Supported in v9.5, v9.7
v9.5: List of Oracle database unique names (DB_UNIQUE_NAME) to exclude from discovery on this Oracle host or RAC. When present and non-empty, replaces the stored exclude-list with exactly these names. An empty or absent array is a no-op; to clear the stored list, set shouldClearExcludedDbUniqueNames to true.
v9.7: List of Oracle database unique names (DB_UNIQUE_NAME) to exclude from discovery on this Oracle host or RAC. When present and non-empty, replaces the stored exclude-list with exactly these names. An empty or absent array is a no-op; to clear the stored list, set shouldClearExcludedDbUniqueNames to true.
- secondaryNodes: list of System.Strings
  - Supported in v9.6+
Ordered list of secondary RAC node names. Array position defines fallback priority when the primary node is unavailable (position 0 = first fallback). REQUIRED when shouldEnableMultiNodeBackup is true (pass an empty array if no secondary fallback nodes are configured).
- backupNodes: list of System.Strings
  - Supported in v9.6+
List of RAC node names designated for multi-node backup. The array order defines channel round-robin assignment. REQUIRED when shouldEnableMultiNodeBackup is true.
