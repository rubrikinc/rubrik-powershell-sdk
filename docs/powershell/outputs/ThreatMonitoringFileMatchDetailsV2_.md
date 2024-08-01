### ThreatMonitoringFileMatchDetailsV2
Reply to ThreatMonitoringFileMatchDetailsV2

- matchedFileMd5: System.String
  - MD5 hash of the matched file.
- matchedFileSha1: System.String
  - SHA1 hash of the matched file.
- matchedFileSha256: System.String
  - SHA256 hash of the matched file.
- iocDetails: list of IOCDetailss
  - IOCs matching the file.
- isQuarantinedInFirstObservedSnapshot: System.Boolean
  - Specifies if the file is quarantined.
- detectedSnapshotDate: DateTime
  - Snapshot date where the match was first detected.
- firstDetectedSnapshotFid: System.String
  - FID of the snapshot where the match was first detected.
- filePath: System.String
  - Filepath that was matched.
- fileName: System.String
  - Name of the file that was matched.
