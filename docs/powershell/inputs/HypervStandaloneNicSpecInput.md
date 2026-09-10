### HypervStandaloneNicSpecInput
Network configuration for a HyperV NIC at recovery time.

- nicInstanceId: System.String
  - WMI instance ID of the source NIC, stable across inventory refreshes.
- sourceNicIndex: System.Int32
  - Index of the source network adapter on the original virtual machine.
- virtualSwitchId: System.String
  - ID of the target virtual switch to connect this NIC to.
- virtualSwitchName: System.String
  - Name of the target virtual switch.
