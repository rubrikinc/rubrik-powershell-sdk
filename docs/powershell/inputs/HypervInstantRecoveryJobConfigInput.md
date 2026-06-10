### HypervInstantRecoveryJobConfigInput
Supported in v5.0+

- hostId: System.String
  - Supported in v5.0+
v5.0-v5.3: ID of the host to instantly recover to
v6.0: ID of the host to instantly recover to.
v7.0+: ID of the instant recovery target host.
- vmName: System.String
  - Name of the new virtual machine to instantly recover.
- removeNetworkDevices: System.Boolean
  - Supported in v9.6
Determines whether to remove the network interfaces from the instantly-recovered virtual machine. 'true' removes all network interfaces. The default value is 'false'.
- shouldMigrateDataStore: System.Boolean
  - Supported in v9.6
Determines whether the Rubrik cluster should perform datastore migration right after instant recovery.
- keepMacAddress: System.Boolean
  - Supported in v9.6
Whether to preserve the original MAC addresses of network adapters.
- virtualSwitchMappings: list of HypervVirtualSwitchMappingInputs
  - Supported in v9.6
Mapping of NIC indices to virtual switches.
- destinationFolder: System.String
  - Supported in v9.6
The destination folder for datastore migration.
