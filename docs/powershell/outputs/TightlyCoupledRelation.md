### TightlyCoupledRelation
TightlyCoupledRelation is one static rule: selecting a resource of type
drags in its connected resources of any type in coupled_types.

- type: ConfigResourceType
  - Resource type the rule applies to.
- coupledTypes: list of ConfigResourceTypes
  - Resource types that are locked together with a selected resource of
type.
