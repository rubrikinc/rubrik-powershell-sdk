### RemoveClusterNodesInput
Request parameters for removing nodes from a cluster.

- nodeIds: list of System.Strings
  - List of node IDs to be removed.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- clusterUuid: System.String
  - Cluster UUID.
- nodeMetadata: list of NodeMetadataInputs
  - Metadata for the nodes.
- resetAfterRemoveType: ResetAfterRemoveType
  - Type of reset to perform after removing the node.
