### ProxmoxVmExportSnapshotJobConfigInput
Configuration for Proxmox virtual machine export job.

- vmId: System.Int32
  - The Proxmox ID for the virtual machine.
- storageId: System.String
  - The ID for the target storage domain for exporting the snapshot.
- diskToStorageMap: list of DiskToStorageInputs
  - Disk to storage mapping.
- snapshotId: System.String
  - Required. The ID of the snapshot to export.
- nodeId: System.String
  - Required. The ID of the target Proxmox node for exporting the snapshot.
- networkId: System.String
  - Required. Network to use in the new virtual machine.
- vmName: System.String
  - The name of the target Proxmox virtual machine.
