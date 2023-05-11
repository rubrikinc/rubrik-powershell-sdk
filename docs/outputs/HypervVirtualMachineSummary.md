### HypervVirtualMachineSummary
Supported in v5.0+

- agentStatus: CdmAgentStatus
  - The status of the Rubrik Backup Service agent for virtual machines.
- cloudInstantiationSpec: CloudInstantiationSpec
  - Supported in v5.0+
  Cloud instantiation specification for the selected virtual machine.
- forceFull: System.Boolean
  - Supported in v6.0+
  Indicates if the Hyper-V virtual machine is configured to perform a full snapshot for the next backup.
- hostId: System.String
  - Required. Supported in v5.0+
  The ID of the Hyper-V host.
- id: System.String
  - Required. Supported in v5.0+
- infraPath: a list of ManagedHierarchyObjectAncestors
  - Required. Supported in v5.0+
  Brief info of all the objects in the infrastructure path to this VM.
- isRelic: System.Boolean
  - Required. Supported in v5.0+
- name: System.String
  - Required. Supported in v5.0+
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v5.3+
  Describes any pending SLA Domain assignment on this object.
- snappable: CdmWorkload
  - 
