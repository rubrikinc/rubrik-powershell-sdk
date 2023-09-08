### OracleDbDetail
Supported in v5.0+

- dbUniqueName: System.String
  - Supported in v5.0-v5.3
  Oracle database unique name. (DB_UNIQUE_NAME)
- isLiveMount: System.Boolean
  - Supported in v5.0+
  v5.0-v5.3: Boolean value that indicates whether a Oracle database object is a Live Mount. Value is true when the object is a Live Mount.
  v6.0+: Value that indicates whether an Oracle database object is a Live Mount or not. A true value indicates that the object is a Live Mount.
- oracleHome: System.String
  - Supported in v5.0+
  Oracle Home of the Oracle database.
- snapshotCount: System.Int32
  - Required. Supported in v5.0+
- tablespaces: list of System.Strings
  - Required. Supported in v5.0+
  An array that contains tablespace names of the specified Oracle database.
- lastValidationResult: OracleLastValidationResult
  - Supported in v5.3+
  General information about last validation job.
- preferredDgMemberUniqueNames: list of System.Strings
  - Supported in v6.0+
  Ordered list of database unique names to use for backup in a Data Guard group.
- shouldBackupFromPrimaryDgGroupMemberOnly: System.Boolean
  - Supported in v6.0+
  Indicates whether to backup only from the PRIMARY Data Guard member or from any available member.
- pdbDetails: OraclePdbDetails
  - Supported in v8.0+
  Details about the PDBs that are part of the CDB.
- sectionSizeInGb: System.Int32
  - Supported in Rubrik CDM version 9.0 and later. Specifies the section size, in gigabytes, to be used during database backup.
- latestRecoveryPointV50: System.String
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV51: System.String
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV52: System.String
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV53: System.String
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV60: DateTime
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV70: DateTime
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV80: DateTime
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV81: DateTime
  - The time stamp of the most recent recovery point for this database.
- latestRecoveryPointV90: DateTime
  - The time stamp of the most recent recovery point for this database.
- oldestRecoveryPointV50: System.String
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV51: System.String
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV52: System.String
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV53: System.String
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV60: DateTime
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV70: DateTime
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV80: DateTime
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV81: DateTime
  - The time stamp of the earliest recovery point for this database.
- oldestRecoveryPointV90: DateTime
  - The time stamp of the earliest recovery point for this database.
- oracleDbSummary: OracleDbSummary
  - 
- oracleNonSlaProperties: OracleNonSlaProperties
  - 
- oldestRecoveryPointV91: DateTime
  - The time stamp of the earliest recovery point for this database.
- latestRecoveryPointV91: DateTime
  - The time stamp of the most recent recovery point for this database.
- hostsInfo: list of HostInfos
  - Supported in v5.3+
  An array that contains the host info for each instance.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
