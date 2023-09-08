### FailoverClusterSummary
Supported in v5.2+

- id: System.String
  - Required. Supported in v5.2+
  ID assigned to the failover cluster.
- name: System.String
  - Required. Supported in v5.2+
  Cluster name assigned to the failover cluster.
- nodes: list of FailoverClusterNodes
  - Required. Supported in v5.2+
  Details of the nodes of this failover cluster.
- primaryClusterId: System.String
  - Required. Supported in v5.2+
- effectiveSlaHolder: EffectiveSlaHolder
  - 
- connectionStatus: FailoverClusterConnectionStatus
  - 
- operatingSystemType: FailoverClusterOsType
  - 
- slaAssignment: SlaAssignment
  - 
- slaAssignable: SlaAssignable
  - 
