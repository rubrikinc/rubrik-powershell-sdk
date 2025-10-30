### ThreatHuntFileVersionMatchDetails
File version match details information containing time-related metadata.

- mtime: DateTime
  - Time at which the file was last modified in the system.
- earliestMatchedSnapshotTime: DateTime
  - Earliest snapshot date containing a match.
- latestMatchedSnapshotTime: DateTime
  - Latest snapshot date containing a match.
- latestSnapshotWithoutVersionTime: DateTime
  - Latest snapshot date without this version.
- isPathQuarantined: System.Boolean
  - Specifies whether the matched file version is quarantined.
- snapshotDetail: list of ThreatHuntSnapshotDetailss
  - Details of the snapshot.
