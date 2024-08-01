### NutanixMountVdisksJobConfigInput
Supported in v9.2+

- shouldMigrateImmediately: System.Boolean
  - Supported in v9.2+
      Specifies whether to trigger migration immediately when the vDisk Mount succeeds.
- containerNaturalId: System.String
  - Supported in v9.2+
      The ID of the storage container that stores the disks of the mounted virtual machine when migration is selected.
- shouldDisableMigration: System.Boolean
  - Required. Supported in v9.2+
      Specifies whether the migration option should not be enabled for the vDisk Mount.
- targetVirtualMachineId: System.String
  - Required. Supported in v9.2+
      ID of the target Nutanix virtual machine where the vDisks will be mounted.
- virtualDiskIds: list of System.Strings
  - Required. Supported in v9.2+
      vDisk IDs to be mounted from the given snapshot.
