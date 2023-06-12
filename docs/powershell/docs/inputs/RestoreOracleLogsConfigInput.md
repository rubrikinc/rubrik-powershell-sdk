### RestoreOracleLogsConfigInput
Supported in v6.0+

- targetMountPath: System.String
  - Supported in v6.0+
      The full path on the target host that serves as the mount point for the NFS share that contains the archive log files.
- oracleLogRecoveryRange: OracleLogRecoveryRangeInput
  - Required. Supported in v6.0+
      Filters for the archive logs to be restored. Exactly one of the filters should be set.
- shouldMountFilesOnly: System.Boolean
  - Required. Supported in v6.0+
      A Boolean value that determines whether to mount the archive log files to the target host without restoring the archive log files. The default value is true.
- targetOracleHostOrRacId: System.String
  - Required. Supported in v6.0+
      The ID of the Oracle host or RAC object targeted by a job that restores Oracle database archive logs. The Oracle host or RAC object must have the Rubrik Backup Service (RBS) installed and connected.
