### ObjectActivitySummariesFilterInput
Filters for ListObjectActivitySummariesReq.

- objectIds: list of System.Strings
  - Object IDs to filter.
- sid: System.String
  - Sid to filter.
- policyId: System.String
  - Policy ID to filter.
- searchStrForObjectName: System.String
  - Search string for object name.
- userActivityType: UserActivityType
  - Activity type to filter. Defaults to UNKNOWN_ACTIVITY.
- risk: RiskLevelType
  - Risk type to filter. Defaults to UNKNOWN_RISK.
