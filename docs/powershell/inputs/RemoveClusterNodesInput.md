### RemoveClusterNodesInput
Request parameters for removing nodes from Rubrik cluster.

- clusterUuid: System.String
  - Cluster UUID.
- nodeIds: list of System.Strings
  - List of node IDs to be removed.
- cloudAccountId: System.String
  - UUID of the customer cloud account. This is not supported for OCI.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- nodeMetadata: list of NodeMetadataInputs
  - Metadata for the nodes.
- resetAfterRemoveType: ResetAfterRemoveType
  - Type of reset to perform after removing the node.
- removeCloudResources: System.Boolean
  - Specifies whether to remove the cloud resources associated with the nodes.
- cloudAccountIdV2: System.String
  - ID of the customer cloud account.
- vendor: CcpVendorType
  - Cloud vendor type.
