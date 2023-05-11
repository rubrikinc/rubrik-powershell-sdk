### HypervExportSnapshotJobConfigInput
Supported in v5.0+

- disableNetwork: System.Boolean
  - Supported in v5.0+
      v5.0-v6.0: Sets the state of the network interfaces when the virtual machine is mounted. Use 'false' to enable the network interfaces. Use 'true' to disable the network interfaces. Disabling the interfaces can prevent IP conflicts. Default value is 'true'.
      v7.0+: Sets the state of the network interfaces when the virtual machine is exported. 'false' enables the network interfaces. 'true' disables the network interfaces. The default value is 'true'. Disabling the interfaces can prevent IP address conflicts.
- hostId: System.String
  - Supported in v5.0+
      v5.0-v5.3: ID of the host to export to
      v6.0: ID of the host to export to.
      v7.0+: ID of the host for export.
- path: System.String
  - Destination path for the new virtual machine virtual disks.
- powerOn: System.Boolean
  - Specifies whether the virtual machine should be powered on after export. The default value is true.
- removeNetworkDevices: System.Boolean
  - Supported in v5.0+
      v5.0-v6.0: Determines whether to remove the network interfaces from the mounted virtual machine. Set to 'true' to remove all network interfaces. The default value is 'false'.
      v7.0+: Specifies whether to remove the network interfaces from the exported virtual machine. When the value is 'true' all the network interfaces are removed. The default value is 'true'.
- vmName: System.String
  - Name of the new virtual machine being exported.
