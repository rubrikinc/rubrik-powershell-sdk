### FailoverClusterSummary
Supported in v5.2+

- connectionStatus: FailoverClusterConnectionStatus
  - Required. Supported in v5.2+
Connectivity status of the failover cluster.
- id: System.String
  - Required. Supported in v5.2+
ID assigned to the failover cluster.
- name: System.String
  - Required. Supported in v5.2+
Cluster name assigned to the failover cluster.
- nodes: list of FailoverClusterNodes
  - Required. Supported in v5.2+
Details of the nodes of this failover cluster.
- operatingSystemType: FailoverClusterOsType
  - Supported in v5.2+
Operating system type of the nodes in the failover cluster.
- primaryClusterId: System.String
  - Required. Supported in v5.2+
- slaAssignment: SlaAssignment
  - Supported in v5.2+
SLA Domain assignment for failover cluster.
- effectiveSlaHolder: EffectiveSlaHolder
- slaAssignable: SlaAssignable
