### RestoreO365TeamsConversationsInput
Input for restoring O365 Teams channel conversations.

- teamUuid: System.String
  -  Teams unique identifier of the channel.
- destTeamsChannelInfo: TeamsChannelInfo
  -  Information about the destination Teams channel.
- shouldCreateDestChannel: System.Boolean
  -  Specifies whether a new destination channel needs to be created in Teams.
- channelInfoForFullRestore: O365TeamConvChannelInput
  -  Information about the destination channel conversation.
- shouldRestoreFileAttachments: System.Boolean
  -  Specifies whether file attachments in the conversation need to be restored.
- teamChannels: list of O365TeamConvChannelInputs
  - O365 Teams conversation channels to restore.
- teamsConversationsSearchFilter: TeamsConversationsSearchFilter
  -  Filters Teams conversations based on the time of posts in the conversations.
- refreshTokenEncrypted: System.String
  - Encrypted refresh token.
- o365AppId: System.String
  - UUID of the O365 App used for authorization.
- channelRecoveryType: ChannelMembershipType
  - Specifies whether the channel being restored is STANDARD or PRIVATE.
- recoverWithLatestPermissions: System.Boolean
  - Specifies whether the newly created Teams channel should have the latest permissions, which maybe different from the permissions at backup time.
- snapshotSequenceNum: System.Int32
  - Specifies the sequence number of the snapshot being currently restored.
