### AzureLocalLogicalNetwork
An ARM logical network attached to the destination custom location, eligible as a
NIC-mapping target for the exported virtual machine.

- id: System.String
  - ARM logical network ID.
- name: System.String
  - Logical network name.
- ipv4Type: AzureLocalIpv4Type
  - Whether the logical network uses static or dynamic IPv4 addressing. Determines
whether a static IP address must be supplied when attaching a NIC to it.
This field is always present on well-formed logical networks.
- addressPrefix: System.String
  - CIDR of the logical network's address space, e.g. "10.1.212.0/23".
Absent for Dynamic networks (ARM does not require a CIDR for DHCP networks).
- ipPools: list of AzureLocalIpPools
  - IP pools defined on this logical network's subnet. Each pool specifies a
contiguous range of addresses available for static assignment. Empty for
Dynamic networks. A network can have more than one pool.
