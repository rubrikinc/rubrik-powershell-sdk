### ExcludeAzureNativeManagedDisksFromSnapshotInput
Inputs to trigger Exclusion of Azure Native Managed Disk From Snapshot.

- virtualMachineRubrikId: System.String
  - Rubrik ID of the virtual machine (VM).
- managedDiskExclusions: list of ManagedDiskExclusions
  - A list that specifies which disks are excluded from snapshots of the virtual machine.
