### ThreatHuntDetails
Details for the threat hunt.

- cdmId: System.String
  - The Rubrik CDM ID of the threat hunt.
- cluster: Cluster
  - The cluster of the scan.
- config: ThreatHuntConfig
  - The configuration of the malware scan.
- endTime: DateTime
  - End time of the hunt.
- snapshots: a list of WorkloadIdToSnapshotIdss
  - The object ids and corresponding snapshot ids targeted for scanning.
- startTime: DateTime
  - Start time of the hunt.
