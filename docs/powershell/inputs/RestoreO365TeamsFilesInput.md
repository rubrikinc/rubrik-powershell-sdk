### RestoreO365TeamsFilesInput
Input for restoring O365 Teams files.

- filesToRestore: list of FileInfos
  - O365 Teams files to restore.
- foldersToRestore: list of FolderInfos
  - O365 Teams folders to restore.
- destTeamsChannelInfo: TeamsChannelInfo
  - Destination channel for the restore.
- shouldCreateDestChannel: System.Boolean
  - Specifies whether destination channel should be created.
- actionType: O365RestoreActionType
  - Recovery action type for the restore job.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for the restore job.
- channelRecoveryType: ChannelMembershipType
  - Indicates whether the channel being restored is STANDARD or PRIVATE.
- recoverWithLatestPermissions: System.Boolean
  - Indicates whether a new channel with latest permissions will be created if a private channel is restored.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
- targetChannelFallbackOwner: System.String
  - Fallback owner of the private and shared channel while restore, as requested in the RSC Web UI.
