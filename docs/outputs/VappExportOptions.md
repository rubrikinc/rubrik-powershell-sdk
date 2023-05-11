### VappExportOptions
Supported in v5.0+

- allChildVmsWithDefaultNetworkConnections: a list of VappVmRestoreSpecs
  - Required. Supported in v5.0+
  Array containing summary information for the vApp virtual machines in the specified vApp snapshot, including the default network mappings.
- availableStoragePolicies: a list of VcdOrgVdcStorageProfiles
  - Required. Supported in v5.0+
  v5.0-v5.3: Storage policies that can be used as a target for VMs being exported.
  v6.0+: Storage policies that can be used as a target for virtual machines being exported.
- restorableNetworks: a list of CreateVappNetworkParamss
  - Required. Supported in v5.0+
  Array of vApp networks in the vApp snapshot being exported that can be enabled at the export location.
- targetVappNetworks: a list of VappNetworkSummarys
  - Supported in v5.0+
  v5.0-v5.1: 
  v5.2+: Array of vApp networks at the export location that can be connected to the vApp virtual machines in the exported vApp snapshot.
