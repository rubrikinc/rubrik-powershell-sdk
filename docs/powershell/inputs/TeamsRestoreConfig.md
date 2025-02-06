### TeamsRestoreConfig
Represents the teams contents to be restored.

- filesRestoreConfig: DriveRestoreConfig
  - Restore configuration for files.
- conversationsRestoreConfig: ConversationsRestoreConfig
  - Restore configuration for conversations.
- destChannelInfo: TeamsChannelInfo
  - Channel information in case of restoration to a new channel.
- shouldCreateDestChannel: System.Boolean
  - Indicates whether a new channel must be created.
- channelType: ChannelMembershipType
  - Indicates whether the channel being restored is STANDARD or PRIVATE.
- restoreLatestPermissions: System.Boolean
  - Indicates whether the new channel will be created with the most recent permissions if a private channel is restored.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
- targetChannelFallbackOwner: System.String
  - Fallback owner of the private and shared channel while restore, as requested in the RSC Web UI.
