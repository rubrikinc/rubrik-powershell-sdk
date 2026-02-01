### CloudDirectGlobalSearchEntry
CloudDirectGlobalSearchEntry represents A single entry in the NAS
Cloud Direct global search results.

- bucket: System.String
  - The bucket that contains this file.
- filename: System.String
  - File name.
- versionId: System.String
  - Version ID of the file.
- lastActivity: DateTime
  - Last modification time.
- size: System.Int64
  - File size in bytes.
- local: System.Boolean
  - Whether the file is present locally.
- remote: System.Boolean
  - Whether the file is present remotely.
- objectId: System.String
  - The object ID this file belongs to.
- shareName: System.String
  - The share name.
- isFile: System.Boolean
  - Whether this entry is a file or directory.
- dirs: list of System.Strings
  - Directory path component.
