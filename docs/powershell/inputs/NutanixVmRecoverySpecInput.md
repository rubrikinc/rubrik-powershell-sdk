### NutanixVmRecoverySpecInput
Nutanix virtual machine recovery specification.

- vCpus: System.Int64
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int64
  - Amount of memory in megabytes to assign to the recovered virtual machine.
- clusterId: System.String
  - ID of the Nutanix cluster for recovery.
- removeAllNetwork: System.Boolean
  - If true, removes the entire network configuration from the recovered virtual
machine.
- preserveMacAddress: System.Boolean
  - If true, preserves the original MAC address in the recovered virtual machine.
- volumes: list of NutanixVmVolumeSpecInputs
  - Storage volume configuration for the recovered virtual machine.
- nics: list of NutanixVmNicSpecInputs
  - Network configuration for the recovered virtual machine.
- target: NutanixComputeTargetInput
  - Compute target configuration for recovery.
