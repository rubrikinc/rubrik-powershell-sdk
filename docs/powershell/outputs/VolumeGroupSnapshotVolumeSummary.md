### VolumeGroupSnapshotVolumeSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
  v5.0-v5.2:
  v5.3+: The unique ID of the snapshot volume summary.
- mountPoints: list of System.Strings
  - Required. Supported in v5.0+
  v5.0-v5.2: Mount point locations of this Volume on the Host
  v5.3+: The mount points of the volume on the host.
- size: System.Int64
  - Required. Supported in v5.0+
  v5.0-v5.2: Size of the Volume in bytes
  v5.3+: The size of the volume in bytes.
- fileSystemType: FileSystemType
  - Required. Supported in v5.0+
  v5.0-v5.2: The file system used by this Volume
  v5.3+: The filesystem of the volume included in the snapshot. Supported filesystems are NTFS and ReFS.
