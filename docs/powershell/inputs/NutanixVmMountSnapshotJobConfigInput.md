### NutanixVmMountSnapshotJobConfigInput
Supported in v6.0+

- containerNaturalId: System.String
  - Supported in v6.0+
      v6.0: The natural ID of the container that will store the disks of the mounted virtual machine when migration is selected.
      v7.0+: The ID of the storage container that will store the disks of the mounted virtual machine when migration is selected.
- nutanixClusterId: System.String
  - Supported in v6.0+
      ID of the Nutanix cluster to mount the new virtual machine to. Default value is the ID of the Nutanix cluster that hosts the source virtual machine of the snapshot.
- shouldMigrateImmediately: System.Boolean
  - Supported in v6.0+
      Specifies whether to trigger migration immediately when the Live Mount succeeds.
- shouldPowerOn: System.Boolean
  - Supported in v6.0+
      v6.0-v8.0: Specifies whether the virtual machine should be powered on after the Live Mount. Default value is true.
      v8.1+: Specifies whether the virtual machine will be powered on after the Live Mount. Default value is false.
- shouldRemoveNetwork: System.Boolean
  - Supported in v6.0+
      Specifies whether to remove network configuration on the new virtual machine. Default value is false.
- targetNetwork: System.String
  - Supported in v6.0+
      The target network on the newly mounted virtual machine if network configuration is not removed.
- vmName: System.String
  - Supported in v6.0+
      Name of the newly mounted virtual machine.
- keepMacAddresses: System.Boolean
  - Supported in v8.1+
      Determines whether the MAC addresses of the network interfaces on the source virtual machine are assigned to the new virtual machine. Set to 'true' to assign the original MAC addresses to the new virtual machine if nicNetworkUuids is provided. Set to 'false' to assign new MAC addresses.The default is 'false'. When removeNetworkDevices is set to true, this property is ignored.
- nicNetworkUuids: list of System.Strings
  - Supported in v8.1+
      The IDs of the Nutanix networks used to create NICs on the exported virtual machine.
- shouldDisableMigration: System.Boolean
  - Required. Specifies whether the migration option should not be enabled for the live mount. When set to true, the Rubrik cluster will serve as the external repository for the mounted virtual machine, and storage migration to the Nutanix cluster will be not be enabled. When set to false, a storage container on the Nutanix cluster must be specified, and a storage migration otion will be available for the live mount when it succeeds.
