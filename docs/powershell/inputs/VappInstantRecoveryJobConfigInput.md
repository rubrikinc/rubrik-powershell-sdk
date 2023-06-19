### VappInstantRecoveryJobConfigInput
Supported in v5.0+

- shouldPowerOnVmsAfterRecovery: System.Boolean
  - Supported in v5.0+
      Boolean value that indicates whether to power on the recovered virtual machines in a vApp after Instant Recovery. Use 'true' to turn the power on for the recovered virtual machines or use 'false' to leave the power off for the virtual machines.
- vmsToRestore: list of VappVmRestoreSpecInputs
  - Required. Supported in v5.0+
      An array containing the restore specification for an Instant Recovery of virtual machines in a vApp snapshot.
