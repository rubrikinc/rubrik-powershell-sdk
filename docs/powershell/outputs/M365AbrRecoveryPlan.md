### M365AbrRecoveryPlan
A saved, named recovery configuration used to trigger an Autonomous
Business Recovery (ABR) for a Microsoft 365 minimum viable company
profile.

- id: System.String
  - Unique identifier of the Recovery Plan.
- name: System.String
  - Display name of the Recovery Plan. Unique within its parent MVC profile.
- description: System.String
  - Free-text user-supplied description.
- workloadTypes: list of O365MvbWorkloadTypes
  - Workload types covered by this recovery plan.
- lastNumberOfDays: System.Int32
  - Number of days of activity history included in this recovery plan.
- conditionTree: M365RecoveryPlanConditionTree
  - Typed filter condition expression currently saved on this Recovery Plan.
Absent when no filters have been saved.
