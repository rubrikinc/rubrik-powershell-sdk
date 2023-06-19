### VolumeGroupOnDemandSnapshotConfigInput
Supported in v5.0+

- volumeIdsIncludedInSnapshot: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.2: IDs of the Volumes which we will include in the snapshot. If not passed, the Volumes currently assigned to the Volume Group will be used.
      v5.3+: The unique ID of each volume included in the Volume Group snapshot.
- baseOnDemandSnapshotConfig: BaseOnDemandSnapshotConfigInput
  - 
