### ThreatHuntResultSnapshotStats
Summary of a threat hunt for a snapshot.

- snapshotFid: System.String
  - ID of the snapshot.
- snapshotDate: DateTime
  - Date of the snapshot.
- totalMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
- status: MalwareScanInSnapshotStatus
  - Status of scanning this snapshot.
- matchTypes: list of IndicatorOfCompromises
  - List of IOCs found in this snapshot.
- snapshotScanStatus: ThreatHuntStatus
  - Status of scanning this snapshot.
- isExpired: System.Boolean
  - Specifies whether the snapshot has expired.
- isQuarantined: System.Boolean
  - Indicates whether the snapshot is quarantined or not.
