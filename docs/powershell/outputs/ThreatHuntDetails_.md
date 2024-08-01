### ThreatHuntDetails
Details for the threat hunt.

- startTime: DateTime
  - Start time of the threat hunt.
- endTime: DateTime
  - End time of the threat hunt.
- snapshots: list of WorkloadIdToSnapshotIdss
  - The object ids and corresponding snapshot ids targeted for scanning.
- cdmId: System.String
  - The Rubrik CDM ID of the threat hunt.
- config: ThreatHuntConfig
  - The configuration of the malware scan.
- cluster: Cluster
  - The cluster of the scan.
