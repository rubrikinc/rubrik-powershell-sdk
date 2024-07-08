### NutanixMountVdisksJobConfigInput


- shouldMigrateImmediately: System.Boolean
  - Specifies whether to trigger migration immediately when the vDisk Mount succeeds.
- containerNaturalId: System.String
  - The ID of the storage container that stores the disks of the mounted virtual machine when migration is selected.
- shouldDisableMigration: System.Boolean
  - Required. Specifies whether the migration option should not be enabled for the vDisk Mount.
- targetVirtualMachineId: System.String
  - Required. ID of the target Nutanix virtual machine where the vDisks will be mounted.
- virtualDiskIds: list of System.Strings
  - Required. vDisk IDs to be mounted from the given snapshot.
