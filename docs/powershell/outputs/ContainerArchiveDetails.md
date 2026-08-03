### ContainerArchiveDetails
Details of the archive file that directly contains the matched file.

- filePath: System.String
  - Path of the outermost archive file within the snapshot.
- fileSize: System.Int64
  - Size of the outermost archive file in bytes.
- md5Hash: System.String
  - MD5 hash of the outermost archive file (hex-encoded).
- sha1Hash: System.String
  - SHA1 hash of the outermost archive file (hex-encoded).
- sha256Hash: System.String
  - SHA256 hash of the outermost archive file (hex-encoded).
- archiveLayers: list of ArchiveLayers
  - Archive layers between the outermost container and the matched file,
ordered from outermost to innermost. Empty when nesting depth is 1
(matched file sits directly inside the outermost archive).
