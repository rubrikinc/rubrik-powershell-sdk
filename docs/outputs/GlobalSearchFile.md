### GlobalSearchFile
Supported in v5.1+

- dirs: a list of System.Strings
  - Required. Supported in v5.1+
  List of directories containing the file.
- filename: System.String
  - Required. Supported in v5.1+
  Filename of the file.
- isFile: System.Boolean
  - Required. Supported in v5.1+
  True if the returned path is not a directory.
- modifiedTime: System.Int64
  - Supported in v7.0+
  Last time, in seconds, this file was modified since epoch.
- numSnapshots: System.Int32
  - Supported in v7.0+
  Number of snapshots containing the file.
- sizeInBytes: System.Int64
  - Supported in v7.0+
  Size, in bytes, of the file.
- snappableId: System.String
  - Required. Supported in v5.1+ Managed ID of the workload containing the file.
- snappableName: System.String
  - Required. Supported in v5.1+ Name of the workload containing the file.
- snapshotTime: System.Int64
  - Supported in v7.0+
  Time latest, in milliseconds, snapshot was taken with this file since epoch.
