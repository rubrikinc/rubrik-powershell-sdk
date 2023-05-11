### VsphereRecoverySpec
The vSphere recovery specification.

- enableMacPreserveOnly: System.Boolean
  - If true, recovery will only preserve the original MAC address for the new virtual machine when network preservation is enabled.
- enableNetworkPreserve: System.Boolean
  - If true, recovery will use the original network configuration for the new virtual machine.
- memoryMbs: System.Int32
  - The amount of memory, in megabytes, to assign to the recovered virtual machine.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- target: VsphereRecoveryComputeTarget
  - Recovery compute target resource configuration.
- userData: System.String
  - The script to be run on the recovered virtual machine after reboot.
- vCpus: System.Int32
  - The number of vCPUs to assign to the recovered virtual machine.
- vSphereNicSpecs: a list of VSphereVMNicSpecs
  - Network configuration for the recovered virtual machine.
- vSphereVolumeSpecs: a list of VSphereVMVolumeSpecs
  - Data volume configuration for the recovered virtual machine.
- version: System.Int64
  - The version of the recovery specification.
