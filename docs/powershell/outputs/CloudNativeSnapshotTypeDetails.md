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
- storageClassTier: System.String
  - Cloud-provider native storage class for the archival location (e.g. "STANDARD", "GLACIER_INSTANT_RETRIEVAL" for AWS S3). Null for non-AWS-native locations, SOURCE/REPLICATED snapshots, and older servers that don't populate the field.
- rcvTier: System.String
  - Rubrik Cloud Vault tier for the archival location (e.g. "BACKUP", "ARCHIVE"). Null for non-RCV locations, SOURCE/REPLICATED snapshots, and older servers that don't populate the field.
