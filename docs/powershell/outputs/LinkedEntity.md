### LinkedEntity
LinkedEntity represents a single AD structural entity row returned by
ListLinkedEntitiesForGPO.

- entityId: System.String
  - Unique identifier of the entity.
- displayName: System.String
  - Human-readable name shown in the UI.
- entityType: PrincipalRiskySummaryPrincipalType
  - AD type (OU, Domain, Site) using the shared PrincipalType.
- linkType: LinkedEntityLinkType
  - Indicates whether the entity is directly or nested-linked.
- linkEnabled: System.Boolean
  - Whether the GPO link is currently active.
- enforced: System.Boolean
  - Whether the GPO link is enforced.
