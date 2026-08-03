### StartRecoveryInput
Request to start a recovery operation.

- recoveryName: System.String
  - User-defined name for the recovery operation.
- dataTransferType: DataTransferType
  - Specifies the method used for transferring data during the recovery operation.
- recoveryFailureAction: RecoveryFailureAction
  - Specifies the action to take when a recovery operation encounters a failure.
- triggeredFrom: RecoveryTriggeredFrom
  - Specifies the source or location from which the recovery operation was
initiated.
- recoveryPlanInfo: RecoveryPlanInfo
  - Recovery plan information for the recovery operation.
- recoverySpecInfo: RecoverySpecInfo
  - Recovery specification information for the recovery operation.
