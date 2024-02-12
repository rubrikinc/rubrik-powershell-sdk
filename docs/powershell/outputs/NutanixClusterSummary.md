### NutanixClusterSummary
Supported in v5.0+

- connectionStatus: RefreshableObjectConnectionStatus
  - Supported in v5.0+
  Connection status of a Nutanix Cluster.
- hostname: System.String
  - Required. Supported in v5.0+
- naturalId: System.String
  - Required. Supported in v5.0+
- username: System.String
  - Required. Supported in v5.0+
- slaAssignable: SlaAssignable
  - 
- prismCentralName: System.String
  - The name of the Nutanix Prism Central to which this Nutanix cluster belongs.
- version: System.String
  - Nutanix Operating System version of the Nutanix cluster.
- prismCentralId: System.String
  - The ID of the Nutanix Prism Central to which this Nutanix cluster belongs.
- lastRefreshTime: DateTime
  - Last refresh time of the Nutanix cluster.
- snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - 
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
