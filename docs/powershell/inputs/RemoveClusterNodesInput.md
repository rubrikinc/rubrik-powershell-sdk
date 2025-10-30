### RemoveClusterNodesInput
Request parameters for removing nodes from a cluster.

- nodeIds: list of System.Strings
  - List of node IDs to be removed.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- removeCloudResources: System.Boolean
  - Specifies whether to remove the cloud resources associated with the nodes.
- clusterUuid: System.String
  - Cluster UUID.
- nodeMetadata: list of NodeMetadataInputs
  - Metadata for the nodes.
- resetAfterRemoveType: ResetAfterRemoveType
  - Type of reset to perform after removing the node.
- cloudAccountId: System.String
  - UUID of the customer cloud account. This is not supported for OCI.
- vendor: CcpVendorType
  - Cloud vendor type.
- cloudAccountIdV2: System.String
  - ID of the customer cloud account.
