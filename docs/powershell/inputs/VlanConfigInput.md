### VlanConfigInput
Supported in v5.0+

- gateway: System.String
  - Gateway for the VLAN.
- alias: System.String
  - Alias for the VLAN.
- interfaces: list of NodeIpInputs
  - Required. Supported in v5.0+
      Network interfaces for each node.
- netmask: System.String
  - Required. Supported in v5.0+
      Netmask for addresses on this VLAN.
- vlan: System.Int32
  - Required. Supported in v5.0+
