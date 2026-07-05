### CloudNativeSnapshotTypeDetails
Recovery details for different snapshot types.

- snapshotId: System.String
  - Snapshot ID for the specific snapshot.
- snapshotType: SnapshotType
  - Snapshot type required for different snapshot types.
- cloudType: CloudProviderType
  - Cloud type required for different snapshot types.
- snapshotRegion: CloudNativeRegion
  - Snapshot region required for different snapshot types.
- cloudNativeAccountId: CloudNativeAccountIdWithName
  - Cloud native account ID required for different snapshot types.
- locationName: System.String
  - Location name for the specific snapshot.
- storageClassTier: CloudNativeStorageClassTier
  - Cloud-provider native storage class for the archival location, grouped per cloud. All sub-fields are null for non-native locations, SOURCE/REPLICATED snapshots, and older servers that don't populate the field.
- rcvTier: RcsTierEnumType
  - Rubrik Cloud Vault tier for the archival location (cloud-agnostic; e.g. BACKUP, ARCHIVE). Null for non-RCV locations, SOURCE/REPLICATED snapshots, and older servers that don't populate the field.
