### ManagedVolumeSlaClientConfig
Client configuration related to backup scripts.

- backupScript: ManagedVolumeSlaScriptConfig
  - Backup script configuration.
- channelHostMountPaths: a list of System.Strings
  - Host mount path for the channels.
- failedPostBackupScript: ManagedVolumeSlaScriptConfig
  - Post failed backup script configuration.
- hostId: System.String
  - Host ID for the channels.
- preBackupScript: ManagedVolumeSlaScriptConfig
  - Pre backup script configuration.
- shouldCancelBackupOnPreBackupScriptFailure: System.Boolean
  - Cancel backup if pre backup script fails.
- successfulPostBackupScript: ManagedVolumeSlaScriptConfig
  - Post successful backup script configuration.
- username: System.String
  - Client username.
