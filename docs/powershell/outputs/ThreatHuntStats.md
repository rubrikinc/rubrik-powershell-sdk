### ThreatHuntStats
Represents the statistics related to the threat hunt.

- totalUniqueMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
- totalAffectedSnapshots: System.Int64
  - Total snapshots in which malware was found.
- totalAffectedObjects: System.Int64
  - Total objects in which malware was found.
- totalSnapshotsScanned: System.Int64
  - Total snapshots scanned.
- totalSucceededScans: System.Int64
  - Total scans where the malware scan succeeded.
- totalUniqueQuarantinedPaths: System.Int64
  - Total unique paths for which malware was found which are also quarantined.
- totalObjectsScanned: System.Int64
  - Total objects scanned.
- totalIocs: System.Int64
  - Total number of IOCs.
- totalProcessedSnapshots: System.Int64
  - Total number of snapshots that are processed.
- totalRegistryKeyMatches: System.Int64
  - Total number of Windows registry key matches.
- totalRegistryAffectedObjects: System.Int64
  - Total objects with at least one Windows registry key match. An object with
both file and registry matches is also counted in the total affected
objects.
- totalRegistryPatterns: System.Int64
  - Total number of Windows registry key patterns, which are not included in
the total number of IOCs.
