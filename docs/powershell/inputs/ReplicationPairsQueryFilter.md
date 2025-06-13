### ReplicationPairsQueryFilter
Filter for replication pairs request.

- clusterName: System.String
  - Rubrik cluster name.
- sourceClusterUuids: list of System.Strings
  - Source Rubrik cluster uuids.
- targetClusterUuids: list of System.Strings
  - Target Rubrik cluster uuids.
- status: list of ReplicationPairConnectionStatuss
  - Connection status of the replication pair.
- bidirectionalStatus: list of ReplicationBidirectionalConnectionStatuss
  - Replication bidirectional connection status filter.
- pauseStatus: list of ReplicationPairPauseStatuss
  - Replication pause status filter.
- sourceAndTargetConnectionStatuses: list of ConnectionStatusTypes
  - Source and target connection status filter.
- targetAndSourceConnectionStatuses: list of ConnectionStatusTypes
  - Target and source connection status filter.
