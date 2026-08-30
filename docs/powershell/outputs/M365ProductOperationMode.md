### M365ProductOperationMode
Stores the dashboard operation mode of a workload type.

- workloadType: M365DashboardWorkloadType
  - Workload type of an M365 organization.
- operationMode: M365DashboardOperationMode
  - Operation mode of the workload type of an M365 organization.
- prioritizedOnboardingStartTime: DateTime
  - Time at which prioritized onboarding started for the workload type. Unset
when the workload type has not entered prioritized onboarding.
- prioritizedOnboardingEndTime: DateTime
  - Time at which prioritized onboarding ended for the workload type. Unset
when prioritized onboarding has not finished.
