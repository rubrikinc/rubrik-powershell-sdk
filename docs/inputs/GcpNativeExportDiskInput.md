### GcpNativeExportDiskInput
Input required to export a GCP native disk snapshot.

- diskEncryptionType: DiskEncryptionType
  - Encryption type of exported disk.
- kmsCryptoKey: KmsCryptoKey
  - Customer managed key to encrypt exported disk. This is only applicable when encryption type is CustomerManagedKey.
- kmsCryptoKeyResourceId: System.String
  - Customer managed key to encrypt exported disk. This is only applicable when encryption type is CustomerManagedKeyResourceId.
- replaceAttached: System.Boolean
  - Specifies whether the exported disk should replace the source disk from the attached instance.
- replicaZones: a list of System.Strings
  - The zones where the regional exported disk should be replicated.
- shouldAddRubrikLabels: System.Boolean
  - Specifies whether to allow Rubrik labels on the exported disk or not.
- shouldCopyLabels: System.Boolean
  - Specfies whether the labels will be copied to the exported disk from the source disk that were there at the time of taking the snapshot or not.
- snapshotId: System.String
  - Snapshot Rubrik ID.
- targetDiskName: System.String
  - The name of the exported disk.
- targetDiskSizeGb: System.Int32
  - The size of the exported disk in GBs.
- targetDiskType: System.String
  - The type of the exported disk.
- targetRegion: System.String
  - The region of the exported disk.
- targetZone: System.String
  - The zone of the exported disk.
