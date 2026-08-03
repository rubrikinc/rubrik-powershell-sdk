### FileMatch
Data for a matched file.

- filepath: System.String
  - Filepath that was matched.
- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- matchedSnapshotDate: DateTime
  - Date of the snapshot when the match was found.
- detectedTime: DateTime
  - Time the scan detected the match.
- isQuarantinedInFirstObservedSnapshot: System.Boolean
  - Indicates whether the file is quarantined in the first observed snapshot.
- fileName: System.String
  - Name of the file that was matched.
- fileSize: System.Int64
  - Size of the file that was matched.
- objectFid: System.String
  - FID of the object.
- matchId: System.Int64
  - ID of the matched file being returned.
- matchedSnapshotFid: System.String
  - FID of the matched snapshot.
- firstObservedSnapshotFid: System.String
  - FID of the first observed snapshot.
- firstObservedSnapshotDate: DateTime
  - Date of the snapshot when the match was first observed.
- mtime: DateTime
  - Modified time of the match.
- fileMetadata: FileMetadata
  - File Metadata for the matched file.
- isFileVersionQuarantined: System.Boolean
  - Indicates whether the workload file version is quarantined.
- isValidated: System.Boolean
  - Indicates whether the match has been validated.
- severity: MatchSeverity
  - Severity of the match.
- isValidationRequired: System.Boolean
  - Indicates whether severity evaluation is required for this match.
True when the match was inserted while delayed detection was active.
False for matches inserted before delayed detection was enabled.
- isInsideArchive: System.Boolean
  - True when the matched file is an inner entry inside a compressed
archive (e.g. zip) discovered via archive expansion.
- archiveRelativePath: System.String
  - Path of this file relative to the root of its parent archive.
Empty string when the matched file is not inside an archive.
- isFirstObservedSnapshotExpired: System.Boolean
  - Specifies whether the first observed snapshot has expired.
- isMatchedSnapshotExpired: System.Boolean
  - Specifies whether the matched snapshot has expired.
- objectType: HierarchyObjectTypeEnum
  - Object type.
- objectName: System.String
  - The scanned object name.
