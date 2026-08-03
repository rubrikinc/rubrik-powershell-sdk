### M365RecoveryPlanFilterComposite
A composite AND/OR node in a filter expression. Children must be non-empty.

- op: RecoveryPlanFilterOp
  - Logical operator applied to all children.
- children: list of M365RecoveryPlanFilterNodes
  - One or more child nodes.
