### SearchCloudDirectWorkloadFileVersion
SearchCloudDirectWorkloadFileVersion represents a specific version of a file in a snapshot.

- snapshotId: System.String
  - The snapshot ID this file version belongs to.
- lastModified: DateTime
  - Last modified time of the file.
- size: System.Int64
  - File size in bytes.
- fileMode: FileModeEnum
  - The type of file (e.g., regular file or directory).
- source: System.String
  - The storage source location (e.g., cloud or local).
