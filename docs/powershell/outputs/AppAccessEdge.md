### AppAccessEdge
A directed edge in the app access graph.

- sourceNodeId: AppAccessNodeId
  - Source slot that this edge originates from.
- destinationNodeId: AppAccessNodeId
  - Destination slot that this edge points to.
- pathType: AccessPathType
  - Access path category for this edge: direct, indirect, or impacted.
- annotation: AppAccessEdgeAnnotation
  - Exactly one value per edge. NONE on every non-IMPACTED edge.
