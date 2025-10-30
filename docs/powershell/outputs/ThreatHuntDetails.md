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
- hashCatalogLimitExceeded: System.Boolean
  - Flag indicating if the hash catalog hits limit has been breached for
the threat hunt (applicable for turbo threat hunts). This can be used to
provide a warning that the turbo threat hunt is not conclusive.
- config: ThreatHuntConfig
  - The configuration of the malware scan.
- cluster: Cluster
  - The cluster of the scan.
