### PitRestoreEntityInputInput
Supported in v9.2+
Inputs required to restore the object to a specific point-in-time.

- hostRecoveryTargets: list of HostRecoveryTargetInputs
  - Required. Supported in v9.2+
List of target hosts for recovery.
- recoveryName: System.String
  - Supported in v9.2+
Recovery name to be used for recovery, default value as kosmos entity cluster name.
- recoveryTime: DateTime
  - Supported in v9.2+
Recovery time at which entity needs to be restored.
- extendedRecoveryTimeInSec: System.Int64
  - Supported in v9.2+
Extra recovery time for logs.
- locationId: System.String
  - Supported in v9.2+
ID of the remote location to download from incase snapshot not available locally.
