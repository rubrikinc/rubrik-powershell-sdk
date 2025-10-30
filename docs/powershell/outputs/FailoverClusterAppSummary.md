### FailoverClusterAppSummary
Supported in v5.2+

- id: System.String
  - Required. Supported in v5.2+
  ID assigned to the failover cluster app.
- primaryClusterId: System.String
  - Required. Supported in v5.2+
- failoverClusterName: System.String
  - Supported in v5.3+
  The failover cluster name of the failover cluster app. The failover cluster is a group of hosts that provides high availability for running failover clustered applications.
- effectiveSlaHolder: EffectiveSlaHolder
  - 
- failoverClusterAppConfig: FailoverClusterAppConfig
  - 
- connectionStatus: FailoverClusterAppConnectionStatus
  - Required. Supported in v5.2+
  Connectivity status of the failover cluster app.
- operatingSystemType: FailoverClusterOsType
  - Supported in v5.3+
  Failover cluster operating system type.
- slaAssignment: SlaAssignment
  - Supported in v5.2+
  SLA Domain assignment for failover cluster app.
- slaAssignable: SlaAssignable
  - 
