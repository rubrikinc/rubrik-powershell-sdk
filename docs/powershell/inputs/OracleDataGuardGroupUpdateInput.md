### OracleDataGuardGroupUpdateInput
Supported in v6.0+

- preferredDgMemberUniqueNames: list of System.Strings
  - Supported in v6.0+
      Ordered list of database unique names to use for backup.
- shouldBackupFromPrimaryOnly: System.Boolean
  - Supported in v6.0+
      Value that indicates whether to backup from the PRIMARY member only, or from any available member.
- oracleUpdateCommon: OracleUpdateCommonInput
  - 
- shouldUseSepsWallet: System.Boolean
  - Supported in v9.0+
      Boolean value specifying whether to use SEPS wallet to connect to the primary database to perform some operations during backup from the standby database.
