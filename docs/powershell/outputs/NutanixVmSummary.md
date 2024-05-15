### NutanixVmSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
- isRelic: System.Boolean
  - Required. Supported in v5.0+
  v5.0-v5.3: Whether this Nutanix VM is currently present on the Nutanix cluster
  v6.0-v8.0: Whether this Nutanix VM is currently present on the Nutanix cluster.
  v8.1+: Specifies whether this Nutanix virtual machine is currently present on the Nutanix cluster.
- name: System.String
  - Required. Supported in v5.0+
- nutanixClusterId: System.String
  - Supported in v5.0+
  v5.0-v5.3: The ID of the Nutanix cluster to which this VM belongs
  v6.0-v8.0: The ID of the Nutanix cluster to which this VM belongs.
  v8.1+: The ID of the Nutanix cluster to which this virtual machine belongs.
- nutanixClusterName: System.String
  - Supported in v5.0+
  v5.0-v5.3: The name of the Nutanix cluster to which this VM belongs
  v6.0-v8.0: The name of the Nutanix cluster to which this VM belongs.
  v8.1+: The name of the Nutanix cluster to which this virtual machine belongs.
- snappable: CdmWorkload
  - 
- agentConnectStatus: AgentConnectStatus
  - 
- operatingSystemType: OperatingSystemType
  - 
- snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - 
- agentStatus: CdmAgentStatus
  - Supported in v5.0+
  The status of the Rubrik Backup Service agent for Nutanix virtual machines.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
