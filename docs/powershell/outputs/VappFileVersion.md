### VappFileVersion
Supported in v5.0+

- fileMode: FileModeEnum
  - Supported in v5.0+
  The type of file, either a regular file or a directory.
- lastModified: DateTime
  - Supported in v5.0+
- size: System.Int64
  - Supported in v5.0+
- snapshotId: System.String
  - Supported in v5.0+
  The snapshot this file belongs to.
- source: VappFileVersionSource
  - Supported in v5.0+
  The location where the file is stored, either in the cloud or locally.
- quarantineInfo: QuarantineInfo
  - Quarantine information corresponding to the path.
- snapshot: CdmSnapshot
  - The detailed information about a snapshot.
