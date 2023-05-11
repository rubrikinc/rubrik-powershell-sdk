### ReplicationPair
Replication pair specific information.

- configDetails: ReplicationPairConfigDetails
  - Configuration details about the replication pair of Rubrik clusters.
- connectionDetails: ConnectionStatusDetails
  - Additional information about the connection status of the replication pair Rubrik clusters.
- failedTasks: System.Int64
  - Failed replication task count in last 24 hours.
- isPaused: System.Boolean
  - Represents replication pair pause enablement status.
- networkThrottle: NetworkThrottle
  - Network throttle details for source Rubrik cluster.
- runningTasks: System.Int64
  - Running replication task count.
- sourceCluster: ReplicationCluster
  - Source Rubrik cluster details.
- status: ReplicationPairConnectionStatus
  - Connection status of the replication pair (active, disconnected, or paused).
- storage: System.Int64
  - Storage (in bytes) consumed on target cluster by replicated snapshots.
- targetCluster: ReplicationCluster
  - Target Rubrik cluster details.
