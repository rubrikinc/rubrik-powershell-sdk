### PitRestoreEntityInputInput
Supported in v9.2+
  Inputs required to restore the object to a specific point-in-time.

- recoveryTime: DateTime
  - Required. Supported in v9.2+
      Recovery time at which entity needs to be restored.
- extendedRecoveryTimeInSec: System.Int64
  - Supported in v9.2+
      Extra recovery time for logs.
- hostRecoveryTargets: list of HostRecoveryTargetInputs
  - Required. Supported in v9.2+
      List of target hosts for recovery.
