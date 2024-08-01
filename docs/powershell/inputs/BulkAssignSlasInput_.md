### BulkAssignSlasInput
Input for multiple SLA Domain assignments to multiple objects at once.

- assignSlaRequests: list of AssignSlasForWorkloadHierarchiesInputs
  - List of SLA Domain assignment request objects.
- parentObjectIdToConflictObjectIdsMap: list of SlaConflictObjectIdsWithParentIds
  - Mapping of a parent object ID to its children object IDs. This should only be populated in case of conflicting SLA assignment, where children objects of a parent object can either retain their direct SLA assignment or inherit new SLA Domain from parent, and these objects are the ones that will be inheriting from parent now.
- userNote: System.String
  - Optional User note.
