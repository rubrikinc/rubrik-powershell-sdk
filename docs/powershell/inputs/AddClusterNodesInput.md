### AddClusterNodesInput
Input for add-nodes-to-cluster operations.

- clusterUuid: System.String
  - Required. ID of the Rubrik cluster.
- request: AddNodesConfigInput
  - Required. The request object for addNodes.
- nodesMap: list of NodesMapInputs
  - Required. IP configuration map for added nodes.
