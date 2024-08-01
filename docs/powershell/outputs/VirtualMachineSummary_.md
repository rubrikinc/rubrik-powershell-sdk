### VirtualMachineSummary
Supported in v5.0+

- clusterName: System.String
  - Supported in v5.0+
- folderPath: list of VmPathPoints
  - Required. Supported in v5.0+
  Brief info of all the objects in the folder path to this VM.
- guestCredentialAuthorizationStatus: System.String
  - Required. Supported in v5.0+
  Status of authentication with a specific virtual machine using guest credentials. Possible values are: SUCCESSFUL, PENDING, or FAILED.
- guestOsName: System.String
  - Supported in v5.0+
- hostId: System.String
  - Supported in v5.0+
- hostName: System.String
  - Supported in v5.0+
- infraPath: list of VmPathPoints
  - Required. Supported in v5.0+
  Brief info of all the objects in the infrastructure path to this VM.
- ipAddress: System.String
  - Required. Supported in v5.0+
- isRelic: System.Boolean
  - Required. Supported in v5.0+
- isReplicationEnabled: System.Boolean
  - Required. Supported in v5.0+
- moid: System.String
  - Required. Supported in v5.0+
- parentAppInfo: ParentAppInfo
  - Supported in v5.0+
  Configuration information for the vApp that manages a specified virtual machine.
- powerStatus: System.String
  - Supported in v5.0+
  The power status of VM(ON,OFF,SLEEP etc.).
- protectionDate: DateTime
  - Supported in v5.0+
- toolsInstalled: System.Boolean
  - Supported in v5.0+
- vcenterId: System.String
  - Supported in v5.0+
- vmwareToolsInstalled: System.Boolean
  - Required. Supported in v5.0+
- instanceUuid: System.String
  - Supported in v8.0+
- snappable: CdmWorkload
  - 
- snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate
  - 
- templateType: VirtualMachineTemplateType
  - Virtual Machine Template summary.
- agentStatus: CdmAgentStatus
  - Supported in v5.0+
  The status of the Rubrik Backup Service agent for virtual machines.
- cloudInstantiationSpec: CloudInstantiationSpec
  - Supported in v5.0+
  Cloud instantiation specification for the selected virtual machine.
- advancedSummary: AdvancedVirtualMachineSummary
  - Supported in v7.0+
