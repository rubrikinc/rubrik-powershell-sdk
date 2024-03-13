### RecoverOracleDbConfigInput
Supported in v5.0+

- numChannels: System.Int32
  - Supported in v5.3+
      v5.3: Number of channels used during instant recovery. The default value is decided based on the number of channels used during backups.
      v6.0+: Number of channels used during instant recovery.
- shouldSkipDropDbInUndo: System.Boolean
  - Indicates whether to skip dropping the database during an undo task if the database was partially recovered.
- recoveryPoint: OracleRecoveryPointInput
  - Required. Supported in v5.0+
      Snapshot ID or timestamp for which the export is done.
