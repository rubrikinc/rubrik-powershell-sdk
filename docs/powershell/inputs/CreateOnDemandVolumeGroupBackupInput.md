### CreateOnDemandVolumeGroupBackupInput


- config: VolumeGroupOnDemandSnapshotConfigInput
  - Configuration for the on-demand backup. Configuration values are `volumeIdsIncludedInSnapshot`, which specifies the unique ID of each volume that is part of this snapshot of the Volume Group, and `slaID`, the ID of the SLA Domain for the snapshot.
- id: System.String
  - Required. The ID of the Volume Group.
