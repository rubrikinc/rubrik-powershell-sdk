### ThreatHuntResultSnapshotStats
Summary of a threat hunt for a snapshot.

- isExpired: System.Boolean
  - Specifies whether the snapshot has expired.
- isQuarantined: System.Boolean
  - Indicates whether the snapshot is quarantined or not.
- matchTypes: a list of IndicatorOfCompromises
  - List of IOCs found in this snapshot.
- snapshotDate: DateTime
  - Date of the snapshot.
- snapshotFid: System.String
  - ID of the snapshot.
- status: MalwareScanInSnapshotStatus
  - Status of scanning this snapshot.
- totalMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
