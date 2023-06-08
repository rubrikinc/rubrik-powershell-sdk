### FailoverClusterNodeOrderInput
Supported in v5.2+

- nodeName: System.String
  - Supported in v5.3+
      The name of the failover cluster node.
- nodeId: System.String
  - Required. Supported in v5.2+
      ID of the failover cluster node.
- order: System.Int32
  - Required. Supported in v5.2+
      An integer that specifies the place occupied by this node in the failover cluster app backup order.
