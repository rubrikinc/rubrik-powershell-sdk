### FullTeamRestoreConfig
Restore configuration for a full Team restore.

- sourceTeamId: System.String
  - RSC ID of the source Team.
- targetTeamOwner: System.String
  - Fallback owner of the destination Team, as requested in the RSC Web UI.
- snapshotSequenceNum: System.Int32
  - The sequence number of the snapshot currently being restored.
- destTeamInfo: DestTeamInfo
  - Information about the destination Team.
- o365AppId: System.String
  - UUID of the O365 App used for authorization.
- refreshTokenEncrypted: System.String
  - Encrypted refresh token.
