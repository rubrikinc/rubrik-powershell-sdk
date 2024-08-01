### GetPendingSlaAssignmentsReply
Supported in v5.2+

- invalidIds: list of System.Strings
  - Required. List of invalid managed IDs from the input. These IDs either do not exist or cannot have an SLA Domain assigned to them.
- objectsWithNoOp: list of ManagedObjectSlaInfos
  - Required. List of objects with completed SLA Domain operations.
- objectsWithPendingOp: list of ManagedObjectPendingSlaInfos
  - Required. List of objects with pending SLA Domain operations.
