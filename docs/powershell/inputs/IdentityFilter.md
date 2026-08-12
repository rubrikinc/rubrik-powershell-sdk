### IdentityFilter
Filters for identity entities.

- targetEntityTypes: list of PrincipalRiskySummaryPrincipalTypes
  - The principal type of the target entity to filter on.
- targetSourceIds: list of System.Strings
  - The source ids of the target entity to filter on.
- excludedTargetEntityTypes: list of PrincipalRiskySummaryPrincipalTypes
  - Principal types to exclude from the results. For example, the main
activity feed excludes DNS_NODE and DNS_ZONE so that DNS activities
surface only on the dedicated DNS page. A caller that scopes to DNS via
target_entity_types overrides the default DNS exclusion and receives DNS
rows.
- targetPrivilegeTypes: list of PrivilegeTypes
  - The privilege types of the target entity to filter on.
