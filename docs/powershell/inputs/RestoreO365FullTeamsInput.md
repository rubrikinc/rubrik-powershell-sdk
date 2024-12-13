### RestoreO365FullTeamsInput
Input for restoring a complete O365 Team.

- teamId: System.String
  - RSC ID of the source Team.
- destTeamInfo: DestTeamInfo
  - Information about the destination Team.
- teamOwnerEmail: System.String
  - Owner of the restored Team.
- snapshotSequenceNum: System.Int32
  - The sequence number of the snapshot currently being restored.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for the restore job.
- refreshTokenEncrypted: System.String
  - Encrypted refresh token.
- o365AppId: System.String
  - UUID of the O365 App used for authorization.
