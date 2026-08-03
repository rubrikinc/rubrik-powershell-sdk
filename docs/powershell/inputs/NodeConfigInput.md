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
- chassisId: System.String
  - Equivalent to BrikID for the node.
- networkZoneName: System.String
  - Optional. Name of the network zone to place the new node in. Requires CDM v9.4+; silently ignored on older Rubrik clusters.
