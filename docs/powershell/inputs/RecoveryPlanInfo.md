### RecoveryPlanInfo
Recovery plan information can be passed either by recovery plan id or by
recovery plan object which will spawn ad hoc recovery. We have left a 3rd
option as well in case we want to pass a recovery plan for ad hoc recovery.

- recoveryPlanId: System.String
  - Recovery plan identifier. If not passed, RSC will start ad hoc recovery.
- isAdhocRecovery: System.Boolean
  - If set to true, RSC initiates an ad hoc recovery and does not require a
recovery plan. Ad hoc recovery is supported only for Cyber Recovery.
