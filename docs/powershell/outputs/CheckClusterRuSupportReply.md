### CheckClusterRuSupportReply
Response for CheckClusterRuSupport.

- clusterUuid: System.String
  - Cluster UUID.
- isRuSupported: System.Boolean
  - Whether the cluster supports Rolling Upgrade (RU).
False if any supportability check fails.
- ruUnsupportabilityReason: System.String
  - Reason why the cluster does not support Rolling Upgrade.
Contains details about the failed supportability check.
Empty string if cluster supports RU.
- clusterUnsupportedWorkloadState: ClusterUnsupportedWorkloadState
  - Classification of the Rubrik cluster's RU-unsupported workloads and their
pause state. See ClusterUnsupportedWorkloadState for the full set
of values.
- unsupportedWorkloads: list of UnsupportedWorkloadTypeInfos
  - One entry per RU-unsupported workload type present on the Rubrik cluster
(G1-excepted types excluded). Empty when
clusterUnsupportedWorkloadState is ALL_WORKLOADS_RU_SUPPORTED.
