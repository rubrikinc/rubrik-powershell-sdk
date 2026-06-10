### FusionComputeMountVmConfigInput
Configuration for a FusionCompute Live Mount request.

- targetHostId: System.String
  - The ID of the target FusionCompute host for mounting the snapshot. At least one of targetHostId or targetClusterId must be provided.
- shouldRecoverTags: System.Boolean
  - Determines whether to recover the tags that were assigned to the virtual machine. The default value is false.
- shouldRemoveNetworkDevices: System.Boolean
  - Determines whether to remove the network interfaces from the mounted virtual machine. The default value is false.
- migrationConfig: FusionComputeDatastoreMigrationConfigInput
  - Configuration for migrating mounted virtual machine disks to a different datastore.
- newVmName: System.String
  - Name of the new virtual machine created by the Live Mount.
- targetClusterId: System.String
  - The ID of the target FusionCompute cluster for mounting the snapshot. At least one of targetHostId or targetClusterId must be provided.
- shouldMigrateImmediately: System.Boolean
  - When true, automatically triggers a datastore migration job after the mount completes. Requires migrationConfig to be set. Defaults to false.
- shouldPowerOn: System.Boolean
  - Determines whether to power on the virtual machine after the mount operation. The default value is true.
- shouldKeepMacAddresses: System.Boolean
  - Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. The default value is false.
- unmountTimeOpt: System.Int64
  - Specifies, in epoch milliseconds, an optional future unmount time for the current live mount.
- shouldDisableNetwork: System.Boolean
  - Sets the state of the network interfaces when the virtual machine is mounted. Use true to disable the network interfaces to prevent IP conflicts. The default value is false.
- networkToNicMap: list of FusionComputeNetworkToNicInputs
  - Network to NIC mapping for the mounted virtual machine.
