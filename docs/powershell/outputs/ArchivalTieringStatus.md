### ArchivalTieringStatus
ArchivalTieringStatus holds the current storage tier and rehydration status
for a snapshot at a specific archival location. Populated from CDM's
archival_tiering_status column, computed server-side by the snapshot service.

- locationId: System.String
  - ID of the archival location this entry applies to.
- currentTier: SnapshotCloudStorageTier
  - Current storage tier for this snapshot's blobs in the given location.
- isFullyTiered: System.Boolean
  - True once all blobs in the snapshot chain are in current_tier.
False means tiering is in progress or partially complete.
- rehydrationNeeded: System.Boolean
  - True when the snapshot requires cloud-provider rehydration before download
can start. Computed server-side from current_tier and is_fully_tiered.
- rehydrationInitiatedAt: DateTime
  - When rehydration was initiated (from CDM's timeToTierBackDown field).
Not set if rehydration has not been requested.
