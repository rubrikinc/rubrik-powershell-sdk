### VcdVappPatchInput
Supported in v5.0+

- configuredSlaDomainId: System.String
  - Supported in v5.0+
      v5.0-v5.1: ID assigned to the SLA Domain object that manages protection for the specified vApp object.
      v5.2-v5.3: ID assigned to the SLA Domain object that manages protection for the specified vApp object. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
      v6.0+: ID assigned to the SLA Domain object that manages protection for the specified vApp object. Existing snapshots of the object will be retained with the configuration of the specified SLA Domain.
- isBestEffortSynchronizationEnabled: System.Boolean
  - Supported in v5.0+
      v5.0-v5.3: Boolean value that indicates whether Rubrik should attempt taking synchronized snapshots across all child Virtual Machines of the vApp.
      v6.0+: Boolean value that indicates whether the Rubrik cluster should attempt taking synchronized snapshots across all child virtual machines of the vApp.
- isPaused: System.Boolean
  - Supported in v5.0+
      Boolean value that indicates whether protection activity is paused for the specified vApp. Set to 'true' when protection activity is paused and 'false' when protection activity is not paused. Protection activity includes backup, replication, and archiving.
- vcdVmMoidsToExcludeFromSnapshot: list of System.Strings
  - Supported in v5.0+
      v5.0-v5.3: Array containing vCloud Director Virtual Machine moids that will be excluded from vApp snapshots.
      v6.0+: Array containing vCloud Director virtual machine moids that will be excluded from vApp snapshots.
