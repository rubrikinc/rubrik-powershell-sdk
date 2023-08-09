### AddNodesToCloudClusterInput
Nodes add request for a cloud cluster.

- numberOfNodes: System.Int32
  - Number of nodes to add.
- shouldKeepResourcesOnFailure: System.Boolean
  - Specifies whether node resources like logs and environment should be saved when the add node operation fails.
- cloudAccountId: System.String
  - Customer cloud account UUID.
- vendor: CcpVendorType
  - Cloud vendor type.
- clusterUuid: System.String
  - Cluster UUID.
