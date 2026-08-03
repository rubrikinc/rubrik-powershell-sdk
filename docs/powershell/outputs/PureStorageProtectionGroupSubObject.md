### PureStorageProtectionGroupSubObject
A volume captured in a Pure Storage protection group snapshot.

- cdmVolumeId: System.String
  - CDM-side volume ID. Pass these values into snapshotVolumeIds on
the PureStorageProtectionGroupExportSnapshotJob mutation to
export a subset of volumes.
- volumeName: System.String
  - Volume name at snapshot time.
- provisionedSizeBytes: System.Int64
  - Provisioned (upper-bound) size of the volume in bytes at snapshot time.
- fileSizeInBytes: System.Int64
  - Actual size used by the volume at snapshot time, in bytes
(0 if not reported).
- pureSnapshotId: System.String
  - Pure FlashArray snapshot ID for this volume.
- snapshotVolumeId: System.String
  - Pure FlashArray snapshot volume ID.
- snapshotVolumeSerialId: System.String
  - Pure FlashArray snapshot volume serial ID (stable across renames).
