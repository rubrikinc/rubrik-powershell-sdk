### ConnectionStatusDetails
Additional information about the connection status of the replication pair Rubrik clusters.

- sourceAndRubrik: ClusterConnectionStatus
  - Connection between source cluster and Rubrik (connected, disconnected, or not added).
- targetAndRubrik: ClusterConnectionStatus
  - Connection between target cluster and Rubrik (connected, disconnected, or not added).
- sourceAndTarget: ConnectionStatusType
  - Connection between source and target Rubrik clusters (connected, disconnected, or unavailable).
- targetAndSource: ConnectionStatusType
  - Connection between target and source Rubrik clusters (connected, disconnected, or unavailable).
- bidirectionalConnectionStatus: ReplicationBidirectionalConnectionStatus
  - Bidirectional connection status between source and target Rubrik clusters: connected, disconnected, or partial.
