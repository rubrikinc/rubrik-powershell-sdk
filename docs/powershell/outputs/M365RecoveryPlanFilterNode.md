### M365RecoveryPlanFilterNode
One node in the boolean condition expression.
Exactly one of leaf or composite must be set.

- leaf: M365RecoveryPlanFilterLeaf
  - Leaf node holding a single primitive predicate.
- composite: M365RecoveryPlanFilterComposite
  - Composite AND/OR node with child nodes.
