### AppAccessPrincipalsFilterInput
Filter for appAccessPrincipals.

- principalId: System.String
  - Source principal (user) whose app access paths are being explored.
- domainId: System.String
  - ID of the identity provider domain.
- principalType: PrincipalRiskySummaryPrincipalType
  - Type of principals to list (e.g., GROUP, SERVICE_ACCOUNT).
- nameFilter: System.String
  - Search by name (case-insensitive contains).
- appFilter: System.String
  - Filter to paths leading to a specific app.
When set, only principals in the path to this app are returned.
- parentPrincipalId: System.String
  - When set and principal_type=SERVICE_PRINCIPAL,
list only apps reachable via this parent principal (group).
- accessPathType: AccessPathType
  - Filter by access path type (direct, indirect, or all).
- timelineDate: System.String
  - Timeline date for time-series data (format: YYYY-MM-DD).
If not provided, defaults to latest available data.
- activityTimestamp: System.String
  - RFC3339 timestamp that pins the query to a point-in-time graph.
Must not be in the future and must be within 30 days of the current time.
- activityId: System.String
  - Optional activity ID whose impact should be overlaid on the PIT graph.
When set, activityTimestamp must also be provided.
- nodeId: AppAccessNodeId
  - Graph node slot to drill into; selects which principal cluster to list.
- activityType: IdentityAlertEventType
  - Activity kind associated with activityId.
Required when activityId is set.
- targetGroupId: System.String
  - Optional group hint to resolve which group the activity targeted.
Mutually exclusive with targetAppId.
- targetAppId: System.String
  - Optional app hint to resolve which application the activity targeted.
Mutually exclusive with targetGroupId.
