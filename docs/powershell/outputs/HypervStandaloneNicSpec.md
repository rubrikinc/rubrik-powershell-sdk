### HypervStandaloneNicSpec
Network configuration for a HyperV NIC at recovery time.

- nicInstanceId: System.String
  - WMI instance ID of the source NIC, stable across inventory refreshes.
- sourceNicIndex: System.Int32
  - Index of the source network adapter on the original virtual machine.
- virtualSwitchId: System.String
  - ID of the target virtual switch to connect this NIC to.
- virtualSwitchName: System.String
  - Name of the target virtual switch.
- ipConfig: NicIpConfig
  - IP configuration for this NIC.
IP configuration for this NIC. Output only in Phase 1; see SPARK-966900 for Phase 2 input support.
