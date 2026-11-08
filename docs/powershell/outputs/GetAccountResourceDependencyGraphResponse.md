### GetAccountResourceDependencyGraphResponse
GetAccountResourceDependencyGraphResponse is the full dependency graph, or
a graceful failure signal if the account+region is too large for this
feature.

- isSuccess: System.Boolean
  - False when the account+region exceeds the resource-count or fan-out
budget, or the reply would exceed the size limit; the caller should fall
back to tag-based onboarding.
- groups: list of AccountResourceGroups
  - Resources grouped by type.
- tightlyCoupledRelations: list of TightlyCoupledRelations
  - Static coupling rules the client uses to lock dependent resources.
- traversalRules: list of ResourceTraversalRules
  - Static traversal rules: when the client selects a node of type, it
follows only edges to nodes whose type is in traversableTypes. Types
without a rule are not traversed.
