### ClusterNodeStats
The node-level performance statistics of a Rubrik cluster.

- cpuStat: System.Int64
  - CPU utilization of the node.
- networkBytesReceived: System.Int64
  - Data received over the network, in bytes per second.
- networkBytesTransmitted: System.Int64
  - Data transmitted over the network, in bytes per second.
- iopsReadsPerSecond: System.Int64
  - Input/output read operations per second.
- iopsWritesPerSecond: System.Int64
  - Input/output write operations per second.
- readThroughputBytesPerSecond: System.Int64
  - Read Input/output throughput, in bytes per second.
- writeThroughputBytesPerSecond: System.Int64
  - Write Input/output throughput, in bytes per second.
- usedMemoryStat: System.Int32
  - Memory used on the node, in percentage.
- clusterPhysicalDataIngest: System.Int64
  - Cluster-level physical data ingestion, in bytes per second.
- time: DateTime
  - Time at which the performance metrics were retrieved.
- clusterId: System.String
  - Rubrik cluster UUID.
- nodeId: System.String
  - Rubrik cluster node ID.
