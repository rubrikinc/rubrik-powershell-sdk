### PrincipalsActivitySummaryCountFilterInput
Principals activity summary count request filter.

- groupId: System.String
  - Filter by group ID.
- objectId: System.String
  - Filter by object ID.
- policyId: System.String
  - Filter by policy ID.
- userRisk: RiskLevelType
  - User risk type to filter. Defaults to UNKNOWN_RISK.
- principalSummaryCategory: PrincipalSummaryCategory
  - Principal summary category. Defaults to USERS_WITH_ACTIVITY.
- userActivityType: UserActivityType
  - Activity type to filter. Defaults to UNKNOWN_ACTIVITY.
