### HypervStandaloneTargetInput
Target standalone HyperV host for recovery.

- hostId: System.String
  - ID of the target HyperV host.
- hostName: System.String
  - Name of the target HyperV host.
- exportPath: System.String
  - Export path on the target HyperV host for the recovered virtual machine.
- nics: list of HypervStandaloneNicSpecInputs
  - Network configuration for each NIC of the recovered virtual machine.
