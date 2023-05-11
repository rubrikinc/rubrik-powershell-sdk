### ConnectionStatusDetails
Additional information about the connection status of the replication pair Rubrik clusters.

- sourceAndRubrik: ClusterConnectionStatus
  - Connection between source cluster and Rubrik (connected, disconnected, or not added).
- sourceAndTarget: ConnectionStatusType
  - Connection between source and target Rubrik clusters (connected or disconnected).
- targetAndRubrik: ClusterConnectionStatus
  - Connection between target cluster and Rubrik (connected, disconnected, or not added).
