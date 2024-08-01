### UserActivitySummariesFilterInput
Filters to use on ListUserActivitySummariesReq.

- userNamePrefix: System.String
  - Prefix for user name search.
- objectId: System.String
  - Object ID.
- groupId: System.String
  - Group ID.
- policyId: System.String
  - Policy ID.
- userRisk: RiskLevelType
  - User risk level.
- principalSummaryCategory: PrincipalSummaryCategory
  - Principal summary category.
- userActivityType: UserActivityType
  - Activity type to filter. Defaults to UNKNOWN_ACTIVITY.
