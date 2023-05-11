### SlaManagedVolumeClientConfigInput
Supported in v5.3+

- backupScript: SlaManagedVolumeScriptConfigInput
  - Required. Supported in v5.3+
      Specifies configuration information for the main backup script that backs up data from the host.
- channelHostMountPaths: a list of System.Strings
  - Required. Supported in v5.3+
      v5.3-v6.0: A list of mount paths where the host mounts individual channels for managed volumes.
      v7.0+: A list of mount paths where the host mounts individual channels for Managed Volumes.
- clientHostId: System.String
  - Required. Supported in v5.3+
      v5.3-v6.0: The ID of the host that mounts the managed volume channels and where the backup scripts run.
      v7.0+: The ID of the host that mounts the Managed Volume channels and location where the backup scripts are run.
- logConfig: ManagedVolumeLogConfigInput
  - Supported in v9.0
      Specifies the configuration for creating log export.
- postBackupScriptOnBackupFailure: SlaManagedVolumeScriptConfigInput
  - Supported in v5.3+
      v5.3-v6.0: Specifies configuration information for the optional post-backup script that runs after data backup failed.
      v7.0+: Specifies configuration information for the optional post-backup script that runs if data backup fails.
- postBackupScriptOnBackupSuccess: SlaManagedVolumeScriptConfigInput
  - Supported in v5.3+
      v5.3-v6.0: Specifies configuration information for the optional post-backup script that runs after data backup is complete.
      v7.0+: Specifies configuration information for the optional post-backup script that runs after data backup completes.
- preBackupScript: SlaManagedVolumeScriptConfigInput
  - Supported in v5.3+
      Specifies configuration information for the optional pre-backup script that runs before data backup begins.
- shouldCancelBackupOnPreBackupScriptFailure: System.Boolean
  - Supported in v5.3+
      Specifies whether a failure of the pre-backup script halts the backup process.
- username: System.String
  - Required. Supported in v5.3+
      v5.3-v6.0: The name of the user that runs the scripts on the host.
      v7.0+: Name of the user running the scripts on the host.
