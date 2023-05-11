### ThreatMonitoringFileMatchDetailsReply
Response to ThreatMonitoringFileMatchDetails.

- detectedSnapshotDate: DateTime
  - Snapshot date where the match was first detected.
- intelSource: System.String
  - Source of the rule that matched.
- iocAttribute: System.String
  - Attribute of the rule that matched.
- isQuarantined: System.Boolean
  - Specifies if the file is quarantined.
- matchType: IndicatorOfCompromiseKind
  - Type of threat match.
- snapshotList: a list of SnapshotDatas
  - List of snapshots that were taken around the detected snapshot date.
