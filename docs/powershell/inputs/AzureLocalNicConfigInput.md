### AzureLocalNicConfigInput
Per-NIC network mapping for the exported virtual machine.

- sourceNicIndex: System.Int32
  - Zero-based index of the network adapter on the source virtual machine that this
entry maps.
- logicalNetworkId: System.String
  - ARM ID of the logical network this NIC attaches to.
- ipv4Type: AzureLocalIpv4Type
  - IPv4 addressing type of the logical network this NIC attaches to.
- ipAllocationMethod: AzureLocalIpAllocationMethod
  - How the IPv4 address is assigned. Required only when the logical network uses
static addressing.
- staticIpAddress: System.String
  - Static IPv4 address to assign. Required only when ipAllocationMethod is MANUAL.
