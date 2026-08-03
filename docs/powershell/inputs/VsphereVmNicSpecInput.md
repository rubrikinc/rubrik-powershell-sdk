### VsphereVmNicSpecInput
VSphere virtual machine NIC specification.

- key: System.String
  - Device key for vsphere NIC identification.
- isPrimaryNic: System.Boolean
  - Indicates if this is the primary network interface.
- networkType: NetworkType
  - Network configuration type (STATIC or DHCP).
- networkId: System.String
  - Internal network ID in our database.
- networkMoid: System.String
  - VSphere managed object ID for the network.
- adapterType: NetworkAdapterType
  - Network adapter type (E1000, VMXNET3, etc.).
- ipv4Address: System.String
  - IPv4 address (required when network_type is STATIC).
- ipv6Address: System.String
  - IPv6 address.
- dnsInfos: list of System.Strings
  - DNS server information.
- gateway: System.String
  - Gateway address (required when network_type is STATIC).
- netmask: System.String
  - Subnet mask (required when network_type is STATIC).
