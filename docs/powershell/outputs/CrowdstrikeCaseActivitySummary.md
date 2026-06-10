### CrowdstrikeCaseActivitySummary
Compact actor summary aggregated across the alerts of a CrowdStrike
case.

- totalActors: System.Int32
  - Count of unique actors across the case's alerts that produced at
least one matched activity in their per-actor window.
- latestActionTime: DateTime
  - Most recent IDP activity across all actors in the case. Null if no
activity in the window.
- totalRelatedActions: System.Int32
  - Count of distinct IDP events across all actors in the case.
- totalTargetEntities: System.Int32
  - Distinct target entities touched across the case's actors.
- totalViolations: System.Int32
  - Sum of lifetime RSC violation counts across the case's unique
actors. Null when the lookup is unavailable.
- impactedIdentityProviders: list of System.Strings
  - IDP labels the actors' activities came from.
- recoveryUrl: System.String
  - Deep link to the appropriate Identity Resilience inventory page.
