### UpdateReplicationNetworkThrottleBypassInput
Input for network throttle bypass update request.

- id: System.String
  - Required. Cluster UUID assigned to the replication target. The replication target should be configured using Private Net.
- config: ReplicationTargetThrottleUpdateInput
  - Required. Updated throttle configuration.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
