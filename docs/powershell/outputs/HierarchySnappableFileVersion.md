### HierarchySnappableFileVersion
A single version of a file, as captured in one snapshot.

- lastModified: DateTime
  - The time at which this version of the file was last modified.
- size: System.Int64
  - The size of this version of the file, in bytes.
- fileMode: FileModeEnum
  - The type of file system entry, such as a file or a directory.
- snapshotId: System.String
  - The FID of the snapshot that contains this version of the file.
- source: FileVersionSourceEnum
  - The location where the file is stored, either in the cloud or locally.
- quarantineInfo: QuarantineInfo
  - Quarantine information corresponding to the path.
- snapshotTime: DateTime
  - The time at which the snapshot containing this version was taken.
- fileCreationTime: DateTime
  - The time at which the file was created. Populated only for CDM clusters
starting from 9.2.2 onwards, and only when the file system supports a
creation time.
- snapshot: CdmSnapshot
  - 
