### ListLinkedEntitiesForGpoFilterInput
ListLinkedEntitiesForGPOFilter specifies optional filter criteria for
ListLinkedEntitiesForGPO.

- entityDisplayName: System.String
  - Filters results by entity name (supports search box).
- principalTypes: list of PrincipalRiskySummaryPrincipalTypes
  - AD entity types to filter on (e.g. OU, DOMAIN_DNS, SITE). Leave empty to return all entity types.
