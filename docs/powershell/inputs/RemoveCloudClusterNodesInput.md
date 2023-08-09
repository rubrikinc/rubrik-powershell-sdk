### RemoveCloudClusterNodesInput
Request parameters for removing nodes from a cloud cluster.

- nodeIds: list of System.Strings
  - List of node IDs to be removed.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- clusterUuid: System.String
  - Cluster UUID.
- cloudAccountId: System.String
  - Customer cloud account UUID.
