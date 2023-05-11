### ThreatHuntResultObjectsSummary
Summary of a threat hunt for an object.

- earliestMatchedSnapshotDate: DateTime
  - Earliest snapshot date containing a match.
- latestMatchedSnapshotDate: DateTime
  - Latest snapshot date containing a match.
- latestSnapshotWithoutMatchDate: DateTime
  - Latest snapshot date not containing a match.
- location: System.String
  - The object location.
- matchTypes: a list of IndicatorOfCompromises
  - List of indicators of compromise (IOCs) found in all the matches.
- object: CdmHierarchySnappableNew
  - The scanned object.
- snapshotsStats: a list of ThreatHuntResultSnapshotStatss
  - Threat hunt summaries for each snapshot.
- totalMatchedPaths: System.Int64
  - Total paths for which malware was found.
- totalMatchedSnapshots: System.Int32
  - Total snapshots where a match was found.
- totalUniqueMatchedPaths: System.Int64
  - Total unique paths for which malware was found.
