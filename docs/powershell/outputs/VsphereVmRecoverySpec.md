### VsphereVmRecoverySpec
VSphere virtual machine recovery specification.

- vcpus: System.Int32
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int32
  - Amount of memory in megabytes to assign to the recovered virtual machine.
- volumes: list of VsphereVmVolumeSpecs
  - Storage volume configuration for the recovered virtual machine.
- nics: list of VsphereVmNicSpecs
  - Network configuration for the recovered virtual machine.
- version: System.Int64
  - Version of the recovery specification (system-managed).
- postScript: System.String
  - The script to be run on the recovered virtual machine after reboot.
- target: VsphereComputeTarget
  - Compute target configuration for recovery.
- enableNetworkPreserve: System.Boolean
  - If true, recovery will use the original network configuration.
- enableMacPreserveOnly: System.Boolean
  - If true, recovery will only preserve the original MAC address when
network preservation is enabled.
- enableNetworkDisconnect: System.Boolean
  - If true, the network will be disconnected for the new virtual
machine during recovery.
