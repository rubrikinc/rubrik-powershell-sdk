### ProxmoxVmExportSnapshotJobConfigInput
Configuration for Proxmox virtual machine export job.

- vmId: System.Int32
  - Supported in v9.5+
The Proxmox ID for the virtual machine.
- powerOn: System.Boolean
  - Specifies whether the virtual machine should be powered on after export. The default value is false.
- storageId: System.String
  - Supported in v9.5+
The ID for the target storage domain for exporting the snapshot.
- diskToStorageMap: list of DiskToStorageInputs
  - Supported in v9.5+
Disk to storage mapping.
- snapshotId: System.String
  - Required. Supported in v9.5+
The ID of the snapshot to export.
- nodeId: System.String
  - Required. Supported in v9.5+
The ID of the target Proxmox node for exporting the snapshot.
- networkId: System.String
  - Required. Supported in v9.5+
Network to use in the new virtual machine.
- vmName: System.String
  - Supported in v9.5+
The name of the target Proxmox virtual machine.
