### MountOracleDbConfigInput
Supported in v5.0+

- shouldMountFilesOnly: System.Boolean
  - Supported in v5.0+
      v5.0: A Boolean value that determines whether the database files are only mounted to the target host without recreating the database.
      v5.1+: A Boolean value that determines whether the database files are mounted to the target host without recreating the database. When 'true', the database is not recreated. When 'false', the database is recreated. The default value is 'false'.
- targetMountPath: System.String
  - Supported in v5.0+
      The full path on the target host where the NFS share with the snapshot files will be mounted.
- advancedRecoveryConfigBase64: System.String
  - Supported in v5.2+
      v5.2-v5.3: Configuration file for advanced Oracle recovery in base64 encoded format.
      v6.0+: The configuration file for Oracle advanced recovery in base64 encoded format. This field cannot be specified if `advancedRecoveryConfigMap` is specified.
- customPfilePath: System.String
  - Supported in v5.3+
      The full path of the pfile on the target Oracle Host or RAC to use for the database recovery.
- numChannels: System.Int32
  - Supported in v5.3+
      v5.3: Number of channels used during live mount. The default value is decided based on the number of channels used during backups.
      v6.0+: Number of channels used during live mount.
- postScriptPath: System.String
  - Supported in v6.0+
      Path to the post-script to run after the recovery task.
- preScriptPath: System.String
  - Supported in v6.0+
      Path to the pre-script to run before the recovery task.
- shouldStopRecoveryOnPreScriptFailure: System.Boolean
  - Supported in v6.0+
      Boolean value that determines whether to stop the recovery task if the pre-script exits with a non-zero value. Set to True to stop the recovery task on pre-script failure. The default setting is False, which allows the task to continue.
- pdbsToLiveMount: list of System.Strings
  - Supported in v8.0+
      List of PDB names to be live mounted in the target database.
- targetRacHostIds: list of System.Strings
  - List of RAC host IDs to recover the database during the Live Mount.
- lmDbName: System.String
  - The new value of the db_name parameter for a LM operation. This is used to specify the new target database name of the live mounted database.
- targetRacPrimaryHostId: System.String
  - Specifies the host ID for the primary RAC node, which will be used for recovery. The provided host ID must be among the list of host IDs specified in targetRacHostIds.
- shouldAllowRenameToSource: System.Boolean
  - Boolean value that determines whether to allow renaming the database back to the source Oracle host or RAC during a Live Mount.
- recoveryPoint: OracleRecoveryPointInput
  - Required. Supported in v5.0+
      v5.0-v5.2: Snapshot ID or timestamp for which the export is done.
      v5.3+: Snapshot ID or timestamp for which the mount is done.
- targetOracleHostOrRacId: System.String
  - Required. Supported in v5.0+
      ID of the Oracle Host or Oracle RAC object for the created database. The referenced Oracle host or RAC must have the Rubrik Backup Service installed and connected. Standalone source databases can be live mounted to OracleHost and clustered source databases can be live mounted to OracleRac only.
