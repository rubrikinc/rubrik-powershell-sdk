### FileMatch
Data for a matched file.

- filepath: System.String
  - Filepath that was matched.
- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- firstMatchedSnapshotDate: DateTime
  - Date of the snapshot when the first match was found.
- detectedTime: DateTime
  - Time the scan detected the match.
- isQuarantined: System.Boolean
  - Specifies if the file is quarantined.
- fileName: System.String
  - Name of the file that was matched.
- fileSize: System.Int64
  - Size of the file that was matched.
- matchId: System.Int64
  - ID of the matched file being returned.
- objectFid: System.String
  - FID of the object.
- snapshotFid: System.String
  - FID of the snapshot.
- objectType: HierarchyObjectTypeEnum
  - Object type.
- objectName: System.String
  - The scanned object name.
