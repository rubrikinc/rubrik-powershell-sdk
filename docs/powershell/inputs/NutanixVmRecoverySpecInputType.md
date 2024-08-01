### NutanixVmRecoverySpecInputType
Recovery spec for the recovered virtual machine.

- vCpus: System.Int64
  - The number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int64
  - The amount of memory, in megabytes, to assign to the recovered virtual machine.
- clusterId: System.String
  - ID of the Nutanix cluster.
- version: System.Int64
  - The version of the recovery specification.
- removeAllNetwork: System.Boolean
  - If true, the entire network configuration will be removed from the recovered virtual machine.
- preserveMacAddress: System.Boolean
  - If true, the original MAC address will be preserved in the recovered virtual machine.
- volumes: list of NutanixVmVolumeSpecInputTypes
  - Storage volume configuration for the recovered virtual machine.
- nics: list of NutanixVmNicSpecInputTypes
  - Network configuration for the recovered virtual machine.
- target: NutanixComputeTargetInputType
  - Compute target for the recovered virtual machine.
