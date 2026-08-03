### OracleRacDetail
Supported in v5.0+

- scan: System.String
  - Required. Supported in v5.0+
Single Client Access Name (SCAN) of the Oracle RAC cluster.
- oracleNonSlaProperties: OracleNonSlaProperties
- oracleRacSummary: OracleRacSummary
- primaryNode: System.String
  - Supported in v9.6+
Name of the RAC node designated as the primary backup node. Empty string when multi-node backup is not configured.
- excludedDbUniqueNames: list of System.Strings
  - Supported in v9.5, v9.7
v9.5: List of Oracle database unique names (DB_UNIQUE_NAME) excluded from discovery on this Oracle RAC. Empty when no databases are excluded.
v9.7: List of Oracle database unique names (DB_UNIQUE_NAME) excluded from discovery on this Oracle RAC. Empty when no databases are excluded.
- secondaryNodes: list of System.Strings
  - Supported in v9.6+
Ordered list of secondary RAC node names. Array position defines fallback priority when the primary node is unavailable (position 0 = first fallback). Empty when multi-node backup is not configured.
- backupNodes: list of System.Strings
  - Supported in v9.6+
List of RAC node names designated for multi-node backup. The array order defines channel round-robin assignment. Empty when multi-node backup is not configured.
