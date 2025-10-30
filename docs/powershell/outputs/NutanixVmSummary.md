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
  - Supported in v9.2+
  The agent connection status.
- operatingSystemType: OperatingSystemType
  - Supported in v5.0+
  The type of the operating system running on the Nutanix virtual machine.
- snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - Required. Supported in v5.0+
  v5.0-v8.0: Consistency level mandated for this VM.
  v8.1+: Consistency level mandated for this virtual machine.
- agentStatus: CdmAgentStatus
  - Supported in v5.0+
  The status of the Rubrik Backup Service agent for Nutanix virtual machines.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
