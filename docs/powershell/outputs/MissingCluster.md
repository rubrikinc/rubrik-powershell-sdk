### MissingCluster
Information about missing clusters.

- name: System.String
  - Cluster name.
- uuid: System.String
  - Cluster UUID.
- version: System.String
  - Cluster version.
- clusterType: System.String
  - Cluster Type.
- numOfNodes: System.Int32
  - Number of nodes in the cluster.
- connectionStatus: MissingClusterConnectionStatus
  - Connection Status of the cluster.
- disconnectedState: MissingClusterDisconnectedState
  - Current state of disconnection for the cluster.
- isExcluded: System.Boolean
  - Specifies whether the cluster is excluded by the customer.
- exclusionReason: System.String
  - Reason for exclusion of cluster connection from RSC.
- nodes: list of System.Strings
  - Nodes in the cluster.
- clusterIp: System.String
  - Cluster IP address.
