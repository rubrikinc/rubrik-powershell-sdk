### ArchiveLayer
One archive in the nesting chain, from the immediate container inward.
Each entry represents one level of archive nesting. The count of entries
equals the nesting depth shown in the UI as "nested {x} layers deep".

- filePath: System.String
  - Path of this archive file within the snapshot.
- sha256Hash: System.String
  - SHA256 hash of this archive file (hex-encoded).
