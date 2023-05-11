### K8sClusterPortsInfo
Represents a range of ports for a Kubernetes cluster.

- kuprClusterUuid: System.String
  - UUID of the Kubernetes cluster.
- maxPort: System.Int32
  - The upper bound (inclusive) of the port range.
- minPort: System.Int32
  - The lower bound (inclusive) of the port range.
- portRangeType: KuprClusterPortsType
  - The type of the port range. Allowed values: 'BACKUP' and 'USER_DRIVEN'. BACKUP type of ports are used for backup and USER_DRIVEN type of ports are used for recovery.
