### ResourceTraversalRule
ResourceTraversalRule is one static rule: selecting a resource of type
follows its edges only to neighbours of a type in traversable_types.

- type: ConfigResourceType
  - Resource type the rule applies to.
- traversableTypes: list of ConfigResourceTypes
  - Neighbour types the client follows when it selects a resource of type.
