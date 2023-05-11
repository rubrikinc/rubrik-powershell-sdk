### FailoverClusterSummary
Supported in v5.2+

- connectionStatus: FailoverClusterConnectionStatus
  - 
- effectiveSlaHolder: EffectiveSlaHolder
  - 
- id: System.String
  - Required. Supported in v5.2+
  ID assigned to the failover cluster.
- name: System.String
  - Required. Supported in v5.2+
  Cluster name assigned to the failover cluster.
- nodes: a list of FailoverClusterNodes
  - Required. Supported in v5.2+
  Details of the nodes of this failover cluster.
- operatingSystemType: FailoverClusterOsType
  - 
- primaryClusterId: System.String
  - Required. Supported in v5.2+
- slaAssignable: SlaAssignable
  - 
- slaAssignment: SlaAssignment
  - 
