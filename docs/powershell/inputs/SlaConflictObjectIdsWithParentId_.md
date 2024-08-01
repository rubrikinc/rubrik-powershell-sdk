### SlaConflictObjectIdsWithParentId
Mapping of a parent object ID to its children object IDs that will now inherit the parent object's new SLA Domain instead of retaining their original direct SLA Domain.

- parentId: System.String
  - ID of the parent object.
- conflictObjects: list of System.Strings
  - IDs of the children workloads that will now inherit the parent object's new SLA Domain instead of retaining their original direct SLA Domain.
