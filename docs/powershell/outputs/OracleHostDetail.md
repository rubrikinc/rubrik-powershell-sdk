### OracleHostDetail
Supported in v5.0+

- oracleHostSummary: OracleHostSummary
- oracleNonSlaProperties: OracleNonSlaProperties
- excludedDbUniqueNames: list of System.Strings
  - Required. Supported in v9.5, v9.7
v9.5: List of Oracle database unique names (DB_UNIQUE_NAME) excluded from discovery on this Oracle host. Empty when no databases are excluded.
v9.7: List of Oracle database unique names (DB_UNIQUE_NAME) excluded from discovery on this Oracle host. Empty when no databases are excluded.
