### VsphereRecoverySpec
The vSphere recovery specification.

- target: VsphereRecoveryComputeTarget
  - Recovery compute target resource configuration.
- vCpus: System.Int32
  - The number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int32
  - The amount of memory, in megabytes, to assign to the recovered virtual machine.
- vSphereVolumeSpecs: list of VSphereVMVolumeSpecs
  - Data volume configuration for the recovered virtual machine.
- vSphereNicSpecs: list of VSphereVMNicSpecs
  - Network configuration for the recovered virtual machine.
- version: System.Int64
  - The version of the recovery specification.
- userData: System.String
  - The script to be run on the recovered virtual machine after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- enableNetworkPreserve: System.Boolean
  - If true, recovery will use the original network configuration for the new virtual machine.
- enableMacPreserveOnly: System.Boolean
  - If true, recovery will only preserve the original MAC address for the new virtual machine when network preservation is enabled.
- enableNetworkDisconnect: System.Boolean
  - If enableNetworkDisconnect is true, the network will be disconnected for the new virtual machine during recovery.
