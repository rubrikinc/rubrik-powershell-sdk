### CloudNativeSnapshotDetailsForRecovery
Recovery related details for a particular snapshot type.

- snapshotType: SnapshotType
  - Type of the snapshot. Can be SOURCE/REPLICATED/ARCHIVED.
- fileRecoveryFeasibility: FileRecoveryFeasibility
  - Field specifying whether file recovery is feasible or not, and if infeasible, the reason for the same.
- cloudType: CloudProviderType
  - Name of the cloud provider. Can be AWS/Azure/GCP. This field is set only if file recovery is feasible.
- snapshotRegion: CloudNativeRegion
  - Region where the particular snapshot exists. This field is set only if file recovery is feasible.
- cloudNativeAccountId: CloudNativeAccountIdWithName
  - Rubrik ID of the cloud account where the particular type of snapshot exists. This field is set only if file recovery is feasible. 
