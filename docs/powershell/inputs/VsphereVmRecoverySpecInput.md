### VsphereVmRecoverySpecInput
VSphere virtual machine recovery specification.

- vcpus: System.Int32
  - Number of vCPUs to assign to the recovered virtual machine.
- memoryMbs: System.Int32
  - Amount of memory in megabytes to assign to the recovered virtual machine.
- volumes: list of VsphereVmVolumeSpecInputs
  - Storage volume configuration for the recovered virtual machine.
- nics: list of VsphereVmNicSpecInputs
  - Network configuration for the recovered virtual machine.
- postScript: System.String
  - The script to be run on the recovered virtual machine after reboot.
- target: VsphereComputeTargetInput
  - Compute target configuration for recovery.
- enableNetworkPreserve: System.Boolean
  - If true, recovery will use the original network configuration.
- enableMacPreserveOnly: System.Boolean
  - If true, recovery will only preserve the original MAC address when
network preservation is enabled.
- postScriptTimestamp: System.String
  - Post script timestamp.
- postScriptHash: System.String
  - Post script hash.
- enableNetworkDisconnect: System.Boolean
  - If true, the network will be disconnected for the new virtual
machine during recovery.
- localAdminPassword: System.String
  - Local administrator password for the virtual machine (optional). Only
required when creating a windows host for ADFR recovery.
UI can provide this value as input, but it will never be returned in API responses.
Backend services can read this field via internal RPC calls.
