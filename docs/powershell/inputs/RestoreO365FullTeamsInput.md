### RestoreO365FullTeamsInput
Request for RestoreO365FullTeamsV2. Reproduces the flat fields of the V1
RestoreO365FullTeamsInput to achieve zero GraphQL schema diff.

- teamId: System.String
  - RSC ID of the source Team.
- destTeamInfo: DestTeamInfo
  - Information about the destination Team.
- teamOwnerEmail: System.String
  - Fallback owner of the destination Team.
- snapshotSequenceNum: System.Int32
  - Sequence number of the snapshot currently being restored.
- snapshotId: System.String
  - ID of the snapshot from which to restore.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration.
- refreshTokenEncrypted: System.String
  - Encrypted refresh token for O365 App authorization.
- o365AppId: System.String
  - UUID of the O365 App used for authorization.
- leaseId: System.String
  - Deprecated: use leaseIds. ID of a just-in-time permission elevation
lease covering this restore's write permissions. Applies in addition to
the leases in leaseIds.
- leaseIds: list of System.Strings
  - IDs of the just-in-time permission elevation leases covering this
restore's write permissions, one per Microsoft 365 app that needed
elevation. Empty when no elevation was required.
