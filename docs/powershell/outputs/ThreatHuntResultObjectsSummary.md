### ThreatHuntResultObjectsSummary
Summary of a threat hunt for an object.

- totalUniqueMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
- totalMatchedPaths: System.Int64
  - Total paths for which malware was found.
- matchTypes: list of IndicatorOfCompromises
  - List of indicators of compromise (IOCs) found in all the matches.
- earliestMatchedSnapshotDate: DateTime
  - Earliest snapshot date containing a match.
- latestMatchedSnapshotDate: DateTime
  - Latest snapshot date containing a match.
- latestSnapshotWithoutMatchDate: DateTime
  - Latest snapshot date not containing a match.
- totalMatchedSnapshots: System.Int32
  - Total snapshots where a match was found.
- objectScanStatus: ThreatHuntObjectStatus
  - Scan status of the object.
- hasQuarantinedMatches: System.Boolean
  - Specifies whether the object has quarantined matches.
- snapshotsStats: list of ThreatHuntResultSnapshotStatss
  - Threat hunt summaries for each snapshot.
- object: CdmHierarchySnappableNew
  - The scanned object.
- clusterInfo: Cluster
  - Cluster information.
- location: System.String
  - The object location.
