### NodeConfigInput
IP configurations for the node.

- dataIpConfig: IpConfigInput
  - IP configuration for data network.
- ipmiIpConfig: IpConfigInput
  - IP configuration for IPMI.
- managementIpConfig: IpConfigInput
  - IP configuration for management network.
- vlanIpConfigs: list of VlanIpInputs
  - VLAN Ids and associated IPs for the node.
