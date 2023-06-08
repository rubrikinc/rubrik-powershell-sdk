### ManagedVolumeSlaClientConfig
Client configuration related to backup scripts.

- username: System.String
  - Client username.
- backupScript: ManagedVolumeSlaScriptConfig
  - Backup script configuration.
- preBackupScript: ManagedVolumeSlaScriptConfig
  - Pre backup script configuration.
- successfulPostBackupScript: ManagedVolumeSlaScriptConfig
  - Post successful backup script configuration.
- failedPostBackupScript: ManagedVolumeSlaScriptConfig
  - Post failed backup script configuration.
- shouldCancelBackupOnPreBackupScriptFailure: System.Boolean
  - Cancel backup if pre backup script fails.
- channelHostMountPaths: list of System.Strings
  - Host mount path for the channels.
- hostId: System.String
  - Host ID for the channels.
