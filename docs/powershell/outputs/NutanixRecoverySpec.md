### NutanixRecoverySpec
Nutanix recovery specification.

- clusterId: System.String
  - ID of the Nutanix cluster.
- vCpus: System.Int64
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int64
  - Amount of memory, in megabytes, to assign to the recovered virtual machine.
- volumes: list of NutanixVMVolumeSpecs
  - Storage volume configuration for the recovered virtual machine.
- nics: list of NutanixVMNicSpecs
  - Network configuration for the recovered virtual machine.
- version: System.Int64
  - Version of the recovery specification.
- userData: System.String
  - Script to run on the recovered virtual machine after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- removeAllNetwork: System.Boolean
  - Determines whether the entire network configuration is removed from the recovered virtual machine.
- preserveMacAddress: System.Boolean
  - Determines whether the original MAC address is preserved in the recovered virtual machine.
- target: NutanixRecoveryComputeTarget
  - Compute target for the recovered virtual machine.
