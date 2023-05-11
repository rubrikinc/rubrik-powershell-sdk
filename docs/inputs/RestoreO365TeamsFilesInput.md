### RestoreO365TeamsFilesInput
Input for restoring O365 Teams files.

- actionType: O365RestoreActionType
  - Recovery task - Restore or Export.
- channelRecoveryType: ChannelMembershipType
  - Indicates whether the channel being restored is STANDARD or PRIVATE.
- destTeamsChannelInfo: TeamsChannelInfo
  - Destination channel for the restore.
- filesToRestore: a list of FileInfos
  - O365 Teams files to restore.
- foldersToRestore: a list of FolderInfos
  - O365 Teams folders to restore.
- recoverWithLatestPermissions: System.Boolean
  - Indicates whether a new channel with latest permissions will be created if a private channel is restored.
- shouldCreateDestChannel: System.Boolean
  - Specifies whether destination channel should be created.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
