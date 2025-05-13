### ThreatHuntDetailsV2
Details for the threat hunt.

- totalObjectFids: System.Int64
  - Total number of object FIDs.
- startTime: DateTime
  - Start time of the threat hunt.
- endTime: DateTime
  - End time of the threat hunt.
- status: ThreatHuntStatus
  - Status of the threat hunt.
- totalMatchedSnapshots: System.Int64
  - Total number of snapshots for which malware was found and hunt succeeded, or partially succeeded, or is in progress.
- totalScannedSnapshots: System.Int64
  - Total number of snapshots across all objects selected for scan.
- totalUniqueFileMatches: System.Int64
  - Total number of unique paths for which malware was found.
- baseConfig: ThreatHuntBaseConfig
  - The configuration of the threat hunt.
- clusters: list of Clusters
  - The Rubrik clusters associated with the threat hunt.
