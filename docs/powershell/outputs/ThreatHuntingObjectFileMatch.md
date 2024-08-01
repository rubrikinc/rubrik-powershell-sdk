### ThreatHuntingObjectFileMatch
Data for a matched file.

- filepath: System.String
  - Matched filepath.
- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- createdTime: DateTime
  - Time at which the file was created in the system.
- modifiedTime: DateTime
  - Time at which the file was last modified in the system.
- earliestMatchedSnapshotDate: DateTime
  - Earliest snapshot date containing a match.
- latestMatchedSnapshotDate: DateTime
  - Latest snapshot date containing a match.
- latestSnapshotWithoutMatchDate: DateTime
  - Latest snapshot date not containing a match.
- matchedSnapshots: list of MatchedSnapshots
  - Information about the snapshots where the file was matched.
- totalSnapshotsScanned: System.Int64
  - Total snapshots where the file was scanned
