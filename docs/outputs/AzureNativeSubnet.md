### AzureNativeSubnet
An Azure subnet. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.

- addressPrefixes: a list of System.Strings
  - List of subnet IP address prefixes in CIDR notation. The list can contain both IPv4 and IPv6 addresses. The list cannot be empty.
- name: System.String
  - Name of the subnet.
- nativeId: System.String
  - Native ID of the subnet.
- vnet: AzureNativeVirtualNetwork
  - Virtual Network (VNet) associated with the subnet.
