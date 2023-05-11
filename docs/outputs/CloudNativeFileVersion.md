### CloudNativeFileVersion
Contains metadata fields of a file specific to the version of the file in a snapshot.

- fileMode: FileModeEnum
  - File mode (directory, file, symlink, or unknown).
- lastModified: DateTime
  - Time when the file was last modified.
- sizeInBytes: System.Int64
  - Size of the file, in bytes.
- snapshot: CloudNativeSnapshotInfo
  - Snapshot corresponding to the file version.
