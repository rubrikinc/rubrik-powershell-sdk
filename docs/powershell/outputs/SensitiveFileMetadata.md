### SensitiveFileMetadata
Represents the metadata of the file.

- path: System.String
  - Path of the file.
- size: System.Int64
  - Size of the file.
- lastModifiedTime: System.Int64
  - Last modified time of the file in milliseconds since epoch.
- creationTime: System.Int64
  - Creation time of the file in milliseconds since epoch.
- lastAccessTime: System.Int64
  - Last accessed time of the file in milliseconds since epoch.
- createdBy: FilePrincipalIdentity
  - Identifies who created the file.
- lastModifiedBy: FilePrincipalIdentity
  - Identifies who last modified the file.
- lastScanTime: System.Int64
  - Last scanned time of the file in milliseconds since epoch.
- numDescendantFiles: System.Int32
  - For a folder, this field represents the number of descendant files.
- dbEntityType: DatabaseEntityType
  - Represents the type of the database entity if the result is in the context of a database
workload.
