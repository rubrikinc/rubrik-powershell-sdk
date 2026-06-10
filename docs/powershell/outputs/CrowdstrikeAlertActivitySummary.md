### CrowdstrikeAlertActivitySummary
Compact actor summary for a single CrowdStrike alert.

- latestActionTime: DateTime
  - Most recent IDP activity by the actor. Null if no activity in
the window.
- totalRelatedActions: System.Int32
  - Count of distinct IDP events by the actor in the window.
- totalTargetEntities: System.Int32
  - Distinct target entities touched by the actor in the window.
- totalViolations: System.Int32
  - Lifetime RSC violation count for the actor. Null when the
violation count is unavailable.
- impactedIdentityProviders: list of System.Strings
  - IDP labels the actor's activities came from (e.g. "Active
Directory", "Microsoft Entra ID", "Okta").
- rollbackUrl: System.String
  - Deep link to the alert in Identity Resilience.
