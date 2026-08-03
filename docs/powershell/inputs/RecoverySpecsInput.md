### RecoverySpecsInput
Request for retrieving recovery specifications related to a particular recovery or
recovery plan.

- getInvalidSpecs: System.Boolean
  - Get invalid recovery specification if true.
- recoveryId: System.String
  - Recovery identifier.
- recoverySpecType: list of RecoverySpecTypeV2s
  - The type of recovery specifications we want to retrieve.
- recoveryPlanId: System.String
  - Recovery plan identifier.
