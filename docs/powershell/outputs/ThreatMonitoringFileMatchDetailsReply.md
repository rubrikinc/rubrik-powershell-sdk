### ThreatMonitoringFileMatchDetailsReply
Response to ThreatMonitoringFileMatchDetails.

- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- intelSource: System.String
  - Source of the rule that matched.
- isQuarantinedInFirstObservedSnapshot: System.Boolean
  - Specifies if the file is quarantined.
- detectedSnapshotDate: DateTime
  - Snapshot date where the match was first detected.
- firstDetectedSnapshotFid: System.String
  - FID of the snapshot where the match was first detected.
- matchedFileMd5: System.String
- matchedFileSha1: System.String
- matchedFileSha256: System.String
- iocRuleName: System.String
  - Attributes of the rule that matched.
- iocRuleAuthor: System.String
- iocRuleDescription: System.String
- filePath: System.String
  - Filepath that was matched.
- fileName: System.String
  - Name of the file that was matched.
- objectFid: System.String
  - FID of the object.
- cluster: Cluster
  - The Rubrik cluster associated with the workload.
