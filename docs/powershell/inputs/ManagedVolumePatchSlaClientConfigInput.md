### ManagedVolumePatchSlaClientConfigInput
Supported in v5.3+

- backupScriptCommand: System.String
  - The full command with arguments to run the main backup script that backs up data from the host.
- backupScriptTimeout: System.Int64
  - Supported in v5.3+
An optional timeout for the main backup script in seconds. When this value is 0 or unspecified no timeout is used.
- channelHostMountPaths: list of System.Strings
  - Supported in v5.3+
A list of mount paths where the host mounts individual channels for managed volumes.
- clientHostId: System.String
  - Supported in v5.3+
The ID of the host that mounts the managed volume channels and where the backup scripts run.
- postBackupScriptOnBackupFailureCommand: System.String
  - The full command with arguments to run the optional post-backup script that runs after unsuccessful data backup.
- postBackupScriptOnBackupFailureTimeout: System.Int64
  - Supported in v5.3+
An optional timeout for the post-backup script that runs after unsuccessful data backup in seconds. When this value is 0 or unspecified no timeout is used.
- postBackupScriptOnBackupSuccessCommand: System.String
  - The full command with arguments to run the optional post-backup script that runs after data backup is complete.
- postBackupScriptOnBackupSuccessTimeout: System.Int64
  - Supported in v5.3+
An optional timeout for the post-backup script that runs after data backup is complete in seconds. When this value is 0 or unspecified no timeout is used.
- preBackupScriptCommand: System.String
  - The full command with arguments to run the optional pre-backup script that runs after data backup is complete.
- preBackupScriptTimeout: System.Int64
  - Supported in v5.3+
An optional timeout for the pre-backup script in seconds. When this value is 0 or unspecified no timeout is used.
- shouldCancelBackupOnPreBackupScriptFailure: System.Boolean
  - Supported in v5.3+
Specifies whether a failure of the pre-backup script halts the backup process.
- shouldDisablePostBackupScriptOnBackupFailure: System.Boolean
  - Required. Supported in v5.3+
Specifies whether to disable the execution of the optional post-backup script that runs after unsuccessful data backup.
- shouldDisablePostBackupScriptOnBackupSuccess: System.Boolean
  - Required. Supported in v5.3+
Specifies whether to disable the execution of the optional post-backup script that runs after data backup is complete.
- shouldDisablePreBackupScript: System.Boolean
  - Required. Supported in v5.3+
Specifies whether to disable the execution of the optional pre-backup script.
- username: System.String
  - Supported in v5.3+
The name of the user that runs the scripts on the host.
