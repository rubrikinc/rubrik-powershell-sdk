### NfAnomalyResultFilterInput
Filter non-filesystem anomaly result data.

- clusterUuid: list of System.Strings
  - Filter by Rubrik cluster ID.
- startTime: DateTime
  - Start of filtering time range.
- endTime: DateTime
  - End of filtering time range.
- isAnomaly: System.Boolean
  - Filter based on anomalous status of the object.
- workloadFid: list of System.Strings
  - Filter by internal object FID.
