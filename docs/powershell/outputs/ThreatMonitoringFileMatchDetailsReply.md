### ThreatMonitoringFileMatchDetailsReply
Response to ThreatMonitoringFileMatchDetails.

- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- intelSource: System.String
  - Source of the rule that matched.
- iocAttribute: System.String
  - Attribute of the rule that matched.
- isQuarantined: System.Boolean
  - Specifies if the file is quarantined.
- detectedSnapshotDate: DateTime
  - Snapshot date where the match was first detected.
- firstDetectedSnapshotFid: System.String
  - FID of the snapshot where the match was first detected.
- matchedFileMd5: System.String
- matchedFileSha1: System.String
- matchedFileSha256: System.String
