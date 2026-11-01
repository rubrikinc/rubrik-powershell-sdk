### ThreatHuntStats
Represents the statistics related to the threat hunt.

- totalUniqueMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
- totalAffectedSnapshots: System.Int64
  - Total snapshots with at least one file or Windows registry key match.
- totalAffectedObjects: System.Int64
  - Total objects with at least one file match.
- totalSnapshotsScanned: System.Int64
  - Total snapshots scanned.
- totalSucceededScans: System.Int64
  - Total scans where the malware scan succeeded.
- totalUniqueQuarantinedPaths: System.Int64
  - Total unique paths for which malware was found which are also quarantined.
- totalObjectsScanned: System.Int64
  - Total objects scanned.
- totalIocs: System.Int64
  - Total number of IOCs, including Windows registry key patterns.
- totalProcessedSnapshots: System.Int64
  - Total number of snapshots that are processed.
- totalRegistryKeyMatches: System.Int64
  - Total number of Windows registry key matches.
- totalRegistryAffectedObjects: System.Int64
  - Total objects with at least one Windows registry key match. An object with
both file and registry matches is also counted in total_affected_objects,
so the two must not be summed.
- totalRegistryPatterns: System.Int64
  - Total number of Windows registry key patterns. These are also included in
total_iocs.
- totalObjectsWithMatches: System.Int64
  - Total number of objects with at least one file or registry key match,
counting each object once. Use this instead of combining
total_affected_objects and total_registry_affected_objects.
