### TeamsRestoreConfig
Represents the teams contents to be restored.

- channelType: ChannelMembershipType
  - Indicates whether the channel being restored is STANDARD or PRIVATE.
- conversationsRestoreConfig: ConversationsRestoreConfig
  - Restore configuration for conversations.
- destChannelInfo: TeamsChannelInfo
  - Channel information in case of restoration to a new channel.
- filesRestoreConfig: DriveRestoreConfig
  - Restore configuration for files.
- restoreLatestPermissions: System.Boolean
  - Indicates whether the new channel will be created with the most recent permissions if a private channel is restored.
- shouldCreateDestChannel: System.Boolean
  - Indicates whether a new channel must be created.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
