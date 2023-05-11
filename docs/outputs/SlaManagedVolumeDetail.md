### SlaManagedVolumeDetail
Supported in v5.3+

- backupScriptDetails: SlaManagedVolumeScriptSummary
  - Required. Supported in v5.3+
  Backup script specifications.
- channelHostMountPaths: a list of System.Strings
  - Required. Supported in v5.3+
  v5.3-v6.0: List of paths the host uses to mount individual channels for managed volumes.
  v7.0: List of paths the host uses to mount individual channels for SLA Managed Volumes.
  v8.0+: List of paths the host uses to mount individual channels for Managed Volumes.
- hostDetails: SlaManagedVolumeHostSummary
  - Required. Supported in v5.3+
  Configuration of the host on which the SLA Managed Volume channels are mounted.
- postBackupScriptOnBackupFailureDetails: SlaManagedVolumeScriptSummary
  - Supported in v5.3+
  v5.3-v6.0: Specifications of the script run after unsuccessful backup.
  v7.0+: Specifications of the script run after an unsuccessful backup.
- postBackupScriptOnBackupSuccessDetails: SlaManagedVolumeScriptSummary
  - Supported in v5.3+
  v5.3-v6.0: Specifications of the script run after successful backup.
  v7.0+: Specifications of the script run after a successful backup.
- preBackupScriptDetails: SlaManagedVolumeScriptSummary
  - Supported in v5.3+
  Specifications of the script run prior to backup.
- shouldCancelBackupOnPreBackupScriptFailure: System.Boolean
  - Supported in v5.3+
  Indicates if a failure of the script run prior to backup halts the backup process.
