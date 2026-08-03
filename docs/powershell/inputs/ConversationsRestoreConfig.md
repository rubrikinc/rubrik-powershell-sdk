### ConversationsRestoreConfig
Represents the conversation contents to be restored.

- SearchFilter: TeamsConversationsSearchFilterJson
  - Filter selecting which conversations to restore.
- ChannelInfoForFullRestore: TeamsConvChannelInfo
  - Destination channel for a full restore.
- RefreshTokenEncrypted: System.String
  - Encrypted refresh token used for the restore.
- O365AppID: System.String
  - The M365 app ID used for the restore.
- ChannelsToRestore: list of TeamsConvChannelInfos
  - The channels to restore.
- ShouldRestoreFileAttachments: System.Boolean
  - Whether to restore file attachments.
