### AnomalyResultFilterInput
Filter anomaly result data.

- clusterUuid: list of System.Strings
  - Filter by Rubrik cluster ID.
- managedId: list of System.Strings
  - Filter by internal managed ID.
- startTime: DateTime
  - Start of filtering time range.
- endTime: DateTime
  - End of filtering time range.
- isAnomaly: System.Boolean
  - Filter based on anomalous status of the snapshot.
- workloadFid: list of System.Strings
  - Filter by internal object fid.
