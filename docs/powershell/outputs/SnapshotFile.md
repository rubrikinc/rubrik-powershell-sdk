### SnapshotFile
File or folder data returned by browse or search delta response.

- filename: System.String
  - The name of the file or folder.
- path: System.String
  - The path of the file or folder, relative to the root of the snapshot.
- absolutePath: System.String
  - The absolute path of the file or folder.
- displayPath: System.String
  - The path of the file or folder, formatted for display.
- lastModified: DateTime
  - Last modified timestamp. Null when modification time
is not available for the entry like directories in
S3/Blob.
- size: System.Int64
  - The size of the file, in bytes.
- fileMode: FileModeEnum
  - The type of the file system entry, such as a file or a directory.
- statusMessage: System.String
  - The status message associated with the file or folder.
- quarantineInfo: QuarantineInfo
  - Quarantine information corresponding to the path.
- workloadFields: WorkloadFields
  - Browse or search delta response returns workload fields.
