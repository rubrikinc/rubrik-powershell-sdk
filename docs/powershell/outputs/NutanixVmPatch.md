### NutanixVmPatch
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Supported in v5.0+
  v5.0-v5.1: Assign this VM to the given SLA domain.
  v5.2-v8.0: Assign this VM to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
  v8.1+: Assigns this virtual machine to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- excludedDiskIds: list of System.Strings
  - Supported in v5.0+
  A list of virtual disks IDs to exclude from the backup for this virtual machine.
- isPaused: System.Boolean
  - Supported in v5.0+
  v5.0-v5.3: Whether backup/archival/replication is paused for this VM
  v6.0-v8.0: Whether backup/archival/replication is paused for this VM.
  v8.1+: Specifies whether backup/archival/replication is paused for this virtual machine.
- postBackupScript: NutanixVirtualMachineScriptDetail
  - Supported in v6.0+
- postSnapScript: NutanixVirtualMachineScriptDetail
  - Supported in v6.0+
- preBackupScript: NutanixVirtualMachineScriptDetail
  - Supported in v6.0+
- snapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - 
