### AppAccessGraphInput
Request for GetAppAccessGraph RPC.

- principalId: System.String
  - ID of the user principal (SID format).
- domainId: System.String
  - ID of the identity provider domain.
- appFilter: System.String
  - Filter to show only paths to a specific app.
- groupFilter: System.String
  - Filter by groups (show paths through specific groups).
- timelineDate: System.String
  - Timeline date for time-series data (format: YYYY-MM-DD).
If not provided, defaults to latest available data.
- accessPathType: AccessPathType
  - Filter by access path type (direct, indirect, or all).
- activityTimestamp: System.String
  - RFC3339 timestamp at which to compute the access graph.
Must not be in the future and must be within 30 days of now.
- activityId: System.String
  - Optional activity ID that overlays an impacted lane on the access graph.
When set, activityTimestamp must also be provided.
- activityType: IdentityAlertEventType
  - Activity kind associated with the activityId.
Required when activityId is set; identifies the event type for impact classification.
- targetGroupId: System.String
  - Optional group hint to resolve which group the activity targeted.
Mutually exclusive with targetAppId.
- targetAppId: System.String
  - Optional app hint to resolve which application the activity targeted.
Mutually exclusive with targetGroupId.
