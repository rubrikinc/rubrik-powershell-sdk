### VappVmRestoreSpec
Supported in v5.0+

- name: System.String
  - Required. Supported in v5.0+
  Name of the specified vApp virtual machine within vCloud.
- networkConnections: a list of VappVmNetworkConnections
  - Required. Supported in v5.0+
- storagePolicyId: System.String
  - Supported in v5.0+
  v5.0-v5.3: Storage policy where this vApp virtual machine should be restored to. If omitted, the VMs will be exported to the default storage policy of the target Organization VDC.
  v6.0+: Storage policy where this vApp virtual machine should be restored to. If omitted, the virtual machines will be exported to the default storage policy of the target Organization VDC.
- vcdMoid: System.String
  - Required. Supported in v5.0+
  vCloud managed object ID (moid) of the specified vApp virtual machine.
