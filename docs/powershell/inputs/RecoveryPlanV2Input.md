### RecoveryPlanV2Input
Recovery plan.

- id: System.String
  - Recovery plan identifier.
- name: System.String
  - Recovery plan name.
- version: System.Int64
  - Version of the recovery plan.
- recoveryPlanType: RecoveryPlanType
  - Recovery plan type.
- workloadType: ManagedObjectType
  - Type of workloads over which this recovery plan is defined.
- sourceLocation: RecoveryPlanLocationInput
  - Source location information.
- targetLocation: RecoveryPlanLocationInput
  - Target location information.
- isHydrationEnabled: System.Boolean
  - If hydration is enabled.
- isHidden: System.Boolean
  - Whether the recovery plan is hidden.
