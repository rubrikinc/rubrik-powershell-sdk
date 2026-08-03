### UserAppAccessData
UserAppAccessData captures the underlying graph data used to compute
appAccessGraph counts and to power appAccessPrincipals.

- directAppSet: list of AppNodes
  - Enriched projections for filtered result sets.
- groupsWithApps: list of GroupNodes
  - Groups with app access.
- indirectAppSet: list of AppNodes
  - Apps accessible via indirect paths.
