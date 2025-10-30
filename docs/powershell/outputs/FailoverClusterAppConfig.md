### FailoverClusterAppConfig
Supported in v5.2+

- configuredSlaDomainId: System.String
  - Supported in v5.2+
  ID of the SLA Domain that is assigned to the specified failover cluster app. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- failoverClusterAppSource: FailoverClusterAppSource
  - Required. Supported in v5.2+
  The source used by the failover cluster app to perform fileset backups. Either a virtual IP address or a node order must be specified in order for the failover cluster app to perform app backup.
- failoverClusterId: System.String
  - Required. Supported in v5.2+
  Cluster ID of the failover cluster app.
- name: System.String
  - Required. Supported in v5.2+
  Name of the failover cluster app.
- failoverClusterType: FailoverClusterType
  - Required. Supported in v5.2+
  Cluster type of the failover cluster app.
