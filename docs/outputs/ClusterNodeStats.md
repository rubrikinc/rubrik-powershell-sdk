### ClusterNodeStats
The node-level performance statistics of a Rubrik cluster.

- clusterId: System.String
  - Rubrik cluster UUID.
- cpuStat: System.Int64
  - CPU utilization of the node.
- iopsReadsPerSecond: System.Int64
  - Input/output read operations per second.
- iopsWritesPerSecond: System.Int64
  - Input/output write operations per second.
- networkBytesReceived: System.Int64
  - Data received over the network, in bytes per second.
- networkBytesTransmitted: System.Int64
  - Data transmitted over the network, in bytes per second.
- nodeId: System.String
  - Rubrik cluster node ID.
- readThroughputBytesPerSecond: System.Int64
  - Read Input/output throughput, in bytes per second.
- time: DateTime
  - Time at which the performance metrics were retrieved.
- usedMemoryStat: System.Int32
  - Memory used on the node, in percentage.
- writeThroughputBytesPerSecond: System.Int64
  - Write Input/output throughput, in bytes per second.
