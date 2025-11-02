### VappVmNetworkConnection
Supported in v5.0+

- addressingMode: VappVmIpAddressingMode
  - Required. Addressing mode of the virtual machine network connection.
- ipAddress: System.String
  - Supported in v5.0+
v5.0-v5.3: IPv4 address to assign to the specified vApp network connection. Only set this value when the network address allocation method is 'Static'. Otherwise, the value should be empty.
v6.0+: IPv4 address to assign to the specified vApp network connection. Set this value only when the network address allocation method is 'Static'. Otherwise, the value should be empty.
- isConnected: System.Boolean
  - Required. Supported in v5.0+
Boolean value that indicates whether the specified vApp network connection is enabled. Set the value to 'true' to enable the connection or 'false' to disable the connection.
- macAddress: System.String
  - Supported in v5.0+
MAC address of the NIC that is used by the specified vApp network connection.
- nicIndex: System.Int32
  - Required. Supported in v5.0+
Index assigned to the NIC that is used by the specified vApp network connection.
- vappNetworkName: System.String
  - Supported in v5.0+
v5.0-v5.3: Name of the vApp network the NIC corresponding to this connection will connect to.
v6.0+: Name of the vApp network to which the NIC corresponding to this connection will connect to.
- networkAdapterType: System.String
  - Supported in v5.3+
v5.3: The network adapter type of this NIC.
v6.0+: The network adapter type of the NIC.
