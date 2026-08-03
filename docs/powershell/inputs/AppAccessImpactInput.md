### AppAccessImpactInput
Input parameters for evaluating the access impact of an identity event.

- activityId: System.String
  - Mandatory -- activity event ID for audit correlation.
- activityType: IdentityAlertEventType
  - Mandatory -- type of the identity event.
- activityTimestamp: System.String
  - Mandatory -- RFC3339 timestamp of the identity event.
- userId: System.String
  - Mandatory -- user whose access impact is being evaluated.
- groupId: System.String
  - Required for membership and group-deletion events.
- appId: System.String
  - Required for app-role assignment events.
- limit: System.Int32
  - Caps how many entries are returned in the apps field per impact entry.
Full count available via appsCount.
