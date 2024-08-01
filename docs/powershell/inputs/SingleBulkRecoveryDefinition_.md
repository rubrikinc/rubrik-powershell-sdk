### SingleBulkRecoveryDefinition
Bulk recovery definition.

- recoveryName: System.String
  - Bulk recovery name. If empty, it will be auto-generated.
- o365GroupSelectorWithRecoverySpec: O365GroupSelectorWithRecoverySpecV2
  - Specifies Office 365 group selector and recovery specifications.
- failureAction: V2FailureActionType
  - Failure action.
- recoveryMode: RecoveryModeType
  - Recovery mode.
- recoveryDomain: RecoveryDomainType
  - Recovery domain.
