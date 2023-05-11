### HotAddProxyVmInfo
Supported in v5.3+

- computeClusterName: System.String
  - Supported in v5.3+
  The name of the compute cluster that contains the HotAdd proxy virtual machine.
- datastoreName: System.String
  - Required. Supported in v5.3+
  The name of the datastore that the HotAdd proxy virtual machine uses.
- hostName: System.String
  - Supported in v5.3+
  The name of the ESX host that contains the HotAdd proxy virtual machine.
- id: System.String
  - Required. Supported in v5.3+
  The ID of the HotAdd proxy virtual machine.
- name: System.String
  - Required. Supported in v5.3+
  The name of the HotAdd proxy virtual machine.
- proxyNetworkInfo: HotAddNetworkConfigWithName
  - Supported in v5.3+
  The network configuration of the HotAdd proxy virtual machine.
- status: HotAddProxyVmStatusType
  - Supported in v5.3+
- usedPortCount: System.Int32
  - Required. Supported in v5.3+
  The number of port in use for the HotAdd proxy virtual machine.
- vcenterName: System.String
  - Required. Supported in v5.3+
  The name of the vCenter that contains the HotAdd proxy virtual machine.
