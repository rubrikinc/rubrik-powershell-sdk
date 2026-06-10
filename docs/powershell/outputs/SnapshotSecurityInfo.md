### SnapshotSecurityInfo
Security information (anomaly, malware, quarantine) of a snapshot.

- workloadId: System.String
  - Workload Identifier.
- snapshotId: System.String
  - Snapshot ID.
- isAnomaly: System.Boolean
  - Whether this snapshot has anomaly detection results.
- hasMalware: System.Boolean
  - Whether this snapshot has malware.
- isQuarantined: System.Boolean
  - Whether this snapshot is quarantined.
- anomalyConfidence: AnomalyConfidenceEnum
  - Anomaly confidence level.
- date: DateTime
  - Snapshot date.
- threatHuntInfo: list of ThreatHuntSnapshotInfos
  - Information about threat hunts on snapshot.
