### VersionedFile
A file matched by a file search, with the versions of the file that are
available in snapshots.

- filename: System.String
  - The name of the file.
- path: System.String
  - The path of the file, relative to the root of the snapshot.
- absolutePath: System.String
  - The absolute path of the file.
- displayPath: System.String
  - The path of the file, formatted for display.
- fileVersions: list of HierarchySnappableFileVersions
  - The versions of the file that are available in snapshots.
