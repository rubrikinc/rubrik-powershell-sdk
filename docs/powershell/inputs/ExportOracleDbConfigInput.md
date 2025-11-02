### ExportOracleDbConfigInput
Supported in v5.0+

- recoveryPoint: OracleRecoveryPointInput
  - Required. Supported in v5.0+
v5.0-v5.2: Snapshot ID or timestamp for which the export is done.
v5.3+: Snapshot ID or timestamp for which the clone is done.
- restoreFilesPath: System.String
  - Supported in v5.0+
The full path for the directory on the target host to use to store the restored database files.
- shouldRestoreFilesOnly: System.Boolean
  - Specifies whether the database files are copied to the target host without recreating the database.
- targetMountPath: System.String
  - Supported in v5.0+
The full path for the directory on the target host where the NFS share will be mounted.
- targetOracleHostOrRacId: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: ID of the Oracle Host or Oracle RAC object that is the target for the export of the specified database snapshot. The referenced Oracle host or RAC must have the Rubrik Backup Service installed and connected. Standalone source databases can be exported to OracleHost and clustered source databases can be exported to OracleRac only.
v5.3+: ID of the Oracle Host or Oracle RAC object that is the target for the clone of the specified database snapshot. The referenced Oracle host or RAC must have the Rubrik Backup Service installed and connected. Standalone source databases can be cloned to OracleHost and clustered source databases can be cloned to OracleRac only.
- advancedRecoveryConfigBase64: System.String
  - Supported in v5.2+
v5.2-v5.3: Configuration file for advanced Oracle recovery in base64 encoded format.
v6.0+: The configuration file for Oracle advanced recovery in base64 encoded format. This field cannot be specified if `advancedRecoveryConfigMap` is specified.
- archiveLogPath: System.String
  - Supported in v5.2+
The full path for the directory containing the archive log files on the Oracle host.
- cloneDbName: System.String
  - Supported in v5.3+
The new value of the db_name parameter for a clone operation. This is used to specify the new name during rman duplicate.
- customPfilePath: System.String
  - Supported in v5.3+
The full path of the pfile on the target Oracle Host or RAC to use for the database recovery.
- numChannels: System.Int32
  - Supported in v6.0+
Number of channels used during clone or same-host recovery.
- postScriptPath: System.String
  - Supported in v6.0+
Path to the post-script to run after the recovery task.
- preScriptPath: System.String
  - Supported in v6.0+
Path to the pre-script to run before the recovery task.
- shouldStopRecoveryOnPreScriptFailure: System.Boolean
  - Supported in v6.0+
Boolean value that determines whether to stop the recovery task if the pre-script exits with a non-zero value. Set to True to stop the recovery task on pre-script failure. The default setting is False, which allows the task to continue.
- pdbsToClone: list of System.Strings
  - Supported in v8.0+
List of PDB names to be cloned in the target database.
- shouldSkipDropDbInUndo: System.Boolean
  - Supported in v8.1+
v8.1-v9.0: Indicates whether to skip dropping the database in undo task if the database was partially recovered.
v9.1+: Indicates whether to skip dropping the database during an undo task if the database was partially recovered.
- targetRacHostIds: list of System.Strings
  - Supported in v9.0+
List of RAC host simple IDs to recover the database during the clone.
- targetRacPrimaryHostId: System.String
  - Supported in v9.0+
Specifies the host simple ID for the primary RAC node, which will be used for recovery. The provided host simple ID must be among the list of host simple IDs specified in `targetRacHostIds`.
- shouldAllowRenameToSource: System.Boolean
  - Supported in v9.0+
A boolean value determines if the database can be renamed back to the source Oracle host or RAC during the clone.
