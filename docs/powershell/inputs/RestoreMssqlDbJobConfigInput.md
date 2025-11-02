### RestoreMssqlDbJobConfigInput
Supported in v5.0+

- finishRecovery: System.Boolean
  - Supported in v5.0+
v5.0-v9.1: A Boolean value that determines the recovery option to use during database restore. When this value is 'true', the database is restored using the RECOVERY option and is fully functional at the end of the restore operation. When this value is 'false', the database is restored using the NORECOVERY option and remains in recovering mode at the end of the restore operation.
v9.2+: Boolean value determining which recovery option to use during a database restore. When this value is 'true', the database is restored using the RECOVERY option and is fully functional at the end of the restore operation. When this value is 'false', the database is restored using the NORECOVERY option and remains in recovering mode at the end of the restore operation.
- maxDataStreams: System.Int32
  - Supported in v5.0+
Maximum number of parallel data streams that can be used to copy data to the target system.
- recoveryPoint: MssqlRecoveryPointInput
  - Required. Supported in v5.0+
