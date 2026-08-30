### HypervVmRecoverySpecInput
Recovery specification for a HyperV virtual machine.

- vCpus: System.Int32
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int64
  - Amount of memory in megabytes to assign to the recovered virtual machine.
- networkMode: NetworkPreservationMode
  - Network preservation mode for the recovered virtual machine.
- shouldDisconnectNetwork: System.Boolean
  - If true, disconnects the network on the recovered virtual machine.
- targetConfig: HypervTargetConfigInput
  - The target configuration for the recovered virtual machine.
