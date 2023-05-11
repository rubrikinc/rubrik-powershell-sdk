### CloudNativeSnapshotDetailsForRecovery
Recovery related details for a particular snapshot type.

- cloudNativeAccountId: CloudNativeAccountIdWithName
  - Rubrik ID of the cloud account where the particular type of snapshot exists. This field is set only if file recovery is feasible. 
- cloudType: CloudProviderType
  - Name of the cloud provider. Can be AWS/Azure/GCP. This field is set only if file recovery is feasible.
- fileRecoveryFeasibility: FileRecoveryFeasibility
  - Field specifying whether file recovery is feasible or not, and if infeasible, the reason for the same.
- snapshotRegion: CloudNativeRegion
  - Region where the particular snapshot exists. This field is set only if file recovery is feasible.
- snapshotType: SnapshotType
  - Type of the snapshot. Can be SOURCE/REPLICATED/ARCHIVED.
