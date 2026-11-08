### HypervRecoverySpecType
HyperV virtual machine recovery specification.

- appId: System.String
  - ID of the recovery plan.
- workloadId: System.String
  - ID of the workload.
- version: System.Int64
  - Version of the recovery specification.
- userData: System.String
  - Script to run on the recovered virtual machine after reboot.
- recoveryPointOpt: System.Int64
  - Recovery point of the workload.
- vCpus: System.Int32
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int64
  - Amount of memory, in megabytes, to assign to the recovered virtual machine.
- shouldDisconnectNetwork: System.Boolean
  - Determines whether the network is disconnected on the recovered virtual machine.
- standaloneTarget: HypervStandaloneTarget
  - Standalone HyperV host target for the recovered virtual machine.
- networkMode: NetworkPreservationMode
  - Network preservation mode for the recovered virtual machine.
