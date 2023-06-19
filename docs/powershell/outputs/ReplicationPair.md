### ReplicationPair
Replication pair specific information.

- storage: System.Int64
  - Storage (in bytes) consumed on target cluster by replicated snapshots.
- status: ReplicationPairConnectionStatus
  - Connection status of the replication pair (active, disconnected, or paused).
- isPaused: System.Boolean
  - Represents replication pair pause enablement status.
- networkThrottle: NetworkThrottle
  - Network throttle details for source Rubrik cluster.
- configDetails: ReplicationPairConfigDetails
  - Configuration details about the replication pair of Rubrik clusters.
- runningTasks: System.Int64
  - Running replication task count.
- failedTasks: System.Int64
  - Failed replication task count in last 24 hours.
- sourceCluster: ReplicationCluster
  - Source Rubrik cluster details.
- targetCluster: ReplicationCluster
  - Target Rubrik cluster details.
- connectionDetails: ConnectionStatusDetails
  - Additional information about the connection status of the replication pair Rubrik clusters.
