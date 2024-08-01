### ReplicationNetworkThrottleBypassReply
Supported in v6.0+

- id: System.String
  - Required. Cluster UUID of the replication target.
- shouldBypassReplicationThrottle: System.Boolean
  - Required. Supported in v6.0+
  If true, the replication throttle is bypassed. An active replication network throttle does not limit outgoing traffic to the replication target. If false, outgoing traffic is limited by an active replication network throttle.
- clusterName: System.String
  - Required. Name of the replication target cluster.
