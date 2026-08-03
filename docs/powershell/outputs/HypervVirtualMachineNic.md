### HypervVirtualMachineNic
HyperV virtual machine network interface (source NIC).

- nicIndex: System.Int32
  - Export mapping key; matches the virtualSwitchMappings index used at recovery.
- instanceId: System.String
  - WMI instance ID, stable across inventory refreshes.
- virtualSwitchId: System.String
  - Source virtual switch identifier.
