### HypervVirtualMachineUpdateInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Assign this virtual machine to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- virtualDiskIdsExcludedFromSnapshot: list of System.Strings
  - Supported in v5.2+
      A comma-separated list of Hyper-V virtual disk IDs that are excluded from backup.
- cloudInstantiationSpec: CloudInstantiationSpecInput
  - Supported in v5.0+
      Cloud instantiation specification for the selected virtual machine.
