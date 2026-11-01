### UpdateHypervVirtualMachineReply
Supported in v5.0+

- guestOsType: HypervVirtualMachineDetailGuestOsType
  - Guest OS type of the virtual machine.
- isAgentRegistered: System.Boolean
  - Supported in v5.0+
Returns whether the Rubrik connector is installed and service is registered.
- operatingSystemType: HypervVirtualMachineDetailOperatingSystemType
  - Operating system type of the virtual machine.
- virtualDiskInfo: list of HypervVirtualDiskInfos
  - Supported in v5.2+
Brief information about all virtual disks of the selected virtual machine.
- naturalId: System.String
  - Natural ID of the virtual machine.
- hypervVirtualMachineSummary: HypervVirtualMachineSummary
  - Summary information about the Hyper-V virtual machine.
- hypervVirtualMachineUpdate: HypervVirtualMachineUpdate
  - Update properties of the Hyper-V virtual machine.
