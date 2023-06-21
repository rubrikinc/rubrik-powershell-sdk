### HypervMountSnapshotJobConfigInput
Supported in v5.0+

- disableNetwork: System.Boolean
  - Supported in v5.0+
      v5.0-v6.0: Sets the state of the network interfaces when the virtual machine is mounted. Use 'false' to enable the network interfaces. Use 'true' to disable the network interfaces. Disabling the interfaces can prevent IP conflicts. Default value is 'true'.
      v7.0+: Sets the state of the network interfaces when the virtual machine is mounted. 'false' enables the network interfaces. 'true' disables the network interfaces. The default value is 'true'. Disabling the interfaces can prevent IP address conflicts.
- hostId: System.String
  - Supported in v5.0+
      v5.0-v5.3: ID of host for the mount to use
      v6.0: ID of host for the mount to use.
      v7.0+: ID of host to be used for mounting the snapshot.
- powerOn: System.Boolean
  - Determines whether the virtual machine should be powered on after mount. The default value is true.
- removeNetworkDevices: System.Boolean
  - Supported in v5.0+
      v5.0-v6.0: Determines whether to remove the network interfaces from the mounted virtual machine. Set to 'true' to remove all network interfaces. The default value is 'false'.
      v7.0+: Determines whether to remove the network interfaces from the mounted virtual machine. 'true' removes all network interfaces. The default value is 'false'.
- vmName: System.String
  - Supported in v5.0+
      v5.0-v5.3: Name of the mounted VM
      v6.0: Name of the mounted VM.
      v7.0+: Name of the mounted virtual machine.
