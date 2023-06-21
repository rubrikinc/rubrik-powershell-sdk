### VirtualMachineUpdateInput
Supported in v5.0+

- cloudInstantiationSpec: CloudInstantiationSpecInput
  - Supported in v5.0+
      Cloud instantiation specification for the selected virtual machine.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.1: Assign this VM to the given SLA domain.
      v5.2+: Assign this VM to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- isArrayIntegrationEnabled: System.Boolean
  - Supported in v5.0+
      User setting to dictate whether to use storage array snaphots for ingest. This setting only makes sense for VMs where array based ingest is possible.
- isVmPaused: System.Boolean
  - Supported in v5.0+
      Whether to pause or resume backups/archival for this VM.
- maxNestedVsphereSnapshots: System.Int32
  - Supported in v5.0+
- postBackupScript: VirtualMachineScriptDetailInput
  - Supported in v5.0+
- postSnapScript: VirtualMachineScriptDetailInput
  - Supported in v5.0+
- preBackupScript: VirtualMachineScriptDetailInput
  - Supported in v5.0+
- throttlingSettings: VmwareAdaptiveThrottlingSettingsInput
  - Supported in v5.0+
- snapshotConsistencyMandate: VirtualMachineUpdateSnapshotConsistencyMandate
  - Supported in v5.0+
      Consistency level mandated for this VM or empty string for none.
