### RestoreO365TeamsFilesInput
Request for restoring or exporting files and folders within a Teams
channel.

- filesToRestore: list of FileInfos
  - Files to restore.
- foldersToRestore: list of FolderInfos
  - Folders to restore.
- destTeamsChannelInfo: TeamsChannelInfo
  - Channel information in case of restoration to a new channel.
- shouldCreateDestChannel: System.Boolean
  - Indicates whether a new channel must be created.
- actionType: O365RestoreActionType
  - Type of restore action to perform.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration; required for in-place restore actions.
- channelRecoveryType: ChannelMembershipType
  - Indicates whether the channel being restored is STANDARD or PRIVATE.
- recoverWithLatestPermissions: System.Boolean
  - Indicates whether the new channel will be created with the most recent
permissions if a private channel is restored.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
- targetChannelFallbackOwner: System.String
  - Fallback owner of the private and shared channel while restore, as
requested in the RSC Web UI.
