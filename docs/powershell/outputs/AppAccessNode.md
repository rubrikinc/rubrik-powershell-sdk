### AppAccessNode
A single slot in the app access graph layout.
Each AppAccessNodeId slot appears at most once per response.
Slots with no content are omitted entirely.

- id: AppAccessNodeId
  - Which bucket this node represents in the graph layout.
- count: System.Int32
  - Number of entities represented by this node.
- principalType: PrincipalRiskySummaryPrincipalType
  - What kind of entity this slot holds.
- principalId: System.String
  - Stable identifier of the entity. Populated only when this node represents a single entity.
- principalName: System.String
  - Display name. Populated only when this node represents a single entity.
- idpType: IdpType
  - Identity provider type. Singletons only.
- logoId: AppLogoId
  - Logo enum for singleton apps. UNSPECIFIED means no known logo.
- nativeType: NativeType
  - Native identity type for this node.
Populated only when this node represents a single entity.
