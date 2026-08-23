### ThreatHuntingObjectFileMatch
Data for a matched file.

- filepath: System.String
  - Matched filepath.
- matchedFileMd5: System.String
  - MD5 hash of the matched file.
- matchedFileSha1: System.String
  - SHA1 hash of the matched file.
- matchedFileSha256: System.String
  - SHA256 hash of the matched file.
- iocDetails: list of ThreatHuntIocDetailss
  - IOCs matching the file.
- isQuarantinedInFirstObservedSnapshot: System.Boolean
  - Specifies if the file is quarantined.
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
  - Total snapshots where the file was scanned.
- totalSnapshotsMatched: System.Int64
  - Total number of snapshots that included the matched file.
- filename: System.String
  - Matched file name.
- matchId: System.Int64
  - ID of the matched file being returned.
- fileVersionMatchDetails: list of ThreatHuntFileVersionMatchDetailss
  - File version match details containing time-related metadata.
There can be multiple file versions for a file match.
- isInsideArchive: System.Boolean
  - True when the matched file is an inner entry inside a compressed
archive (e.g. zip) discovered via archive expansion.
- archiveRelativePath: System.String
  - Path of this file relative to the root of its parent archive.
Empty string when the matched file is not inside an archive.
- containerArchiveDetails: ContainerArchiveDetails
  - Details of the archive container when the matched file is an inner entry
discovered via archive expansion. Unset when is_inside_archive is false.
