### KuprServerProxyConfigInput
Supported in v9.2+
The configuration of kupr server proxy.

- cert: System.String
  - Required. Supported in v9.2+
Public Certificate of kupr server proxy.
- port: System.Int32
  - Supported in v9.2+
Port number of kupr server proxy.
- ipAddress: System.String
  - Required. Supported in v9.2+
v9.2-v9.5: The IP address of kupr server proxy for either nodeport or loadbalancer.
v9.6: The address (IPv4, IPv6, or DNS hostname) of the kupr server proxy for nodeport, loadbalancer, or multus transport. For IPv6 addresses, provide the bare address without brackets (e.g. "2001:db8::1"); brackets are added automatically when generating kubeconfigs.
