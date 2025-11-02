### FailoverClusterAppSummary
Supported in v5.2+

- connectionStatus: FailoverClusterAppConnectionStatus
  - Required. Supported in v5.2+
Connectivity status of the failover cluster app.
- id: System.String
  - Required. Supported in v5.2+
ID assigned to the failover cluster app.
- primaryClusterId: System.String
  - Required. Supported in v5.2+
- slaAssignment: SlaAssignment
  - Supported in v5.2+
SLA Domain assignment for failover cluster app.
- failoverClusterName: System.String
  - Supported in v5.3+
The failover cluster name of the failover cluster app. The failover cluster is a group of hosts that provides high availability for running failover clustered applications.
- operatingSystemType: FailoverClusterOsType
  - Supported in v5.3+
Failover cluster operating system type.
- effectiveSlaHolder: EffectiveSlaHolder
- failoverClusterAppConfig: FailoverClusterAppConfig
- slaAssignable: SlaAssignable
