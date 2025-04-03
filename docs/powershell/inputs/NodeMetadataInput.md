### NodeMetadataInput
Details of a node.

- nodeId: System.String
  - The ID of the node to be removed.
- chassisId: System.String
  - The ID of the chassis the node is on.
- platform: ClusterNodePlatformType
  - The platform the node is on.
- status: ClusterNodeStatus
  - The status of the node.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain.
- resetAfterRemoveType: ResetAfterRemoveType
  - Type of reset to perform after removing the node.
