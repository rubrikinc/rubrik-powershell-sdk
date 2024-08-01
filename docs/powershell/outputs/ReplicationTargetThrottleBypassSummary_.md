### ReplicationTargetThrottleBypassSummary
Replication Network Throttle Bypass Summary List Response.

- id: System.String
  - Cluster Uuid of the target Rubrik cluster.
- shouldBypassReplicationThrottle: System.Boolean
  - If true, the replication throttle is bypassed. An active replication network throttle
        does not limit outgoing traffic to the replication target. If false, outgoing traffic is
        limited by an active replication network throttle.
- clusterName: System.String
  - Cluster name of the target Rubrik cluster.
