### SlaConflictObjectsWithParent
Response containing the conflicting objects for an SLA Domain assignment grouped by the parent IDs that are sent in the request.

- parentId: System.String
  - One of the IDs in the request which is an ancestor of the conflicting objects.
- conflictObjects: list of HierarchyObjects
  - The list of objects which have an SLA Domain applied to them resulting in a conflict with the parent object.
