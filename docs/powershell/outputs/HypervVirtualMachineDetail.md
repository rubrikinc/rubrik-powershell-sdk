### HypervVirtualMachineDetail
Supported in v5.0+

- isAgentRegistered: System.Boolean
  - Supported in v5.0+
  Returns whether the Rubrik connector is installed and service is registered.
- naturalId: System.String
- hypervVirtualMachineSummary: HypervVirtualMachineSummary
  - 
- hypervVirtualMachineUpdate: HypervVirtualMachineUpdate
  - 
- guestOsType: HypervVirtualMachineDetailGuestOsType
- operatingSystemType: HypervVirtualMachineDetailOperatingSystemType
- virtualDiskInfo: list of HypervVirtualDiskInfos
  - Supported in v5.2+
  Brief information about all virtual disks of the selected virtual machine.
