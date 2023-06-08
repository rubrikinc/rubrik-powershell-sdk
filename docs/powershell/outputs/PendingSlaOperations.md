### PendingSlaOperations
Supported in v5.2+

- invalidIds: list of System.Strings
  - Required. Supported in v5.2+
  List of invalid managed IDs from input. They either do not exist or cannot have an SLA assigned to them.
- objectsWithNoOp: list of ManagedObjectSlaInfos
  - Required. Supported in v5.2+
  List of objects with completed SLA operations.
- objectsWithPendingOp: list of ManagedObjectPendingSlaInfos
  - Required. Supported in v5.2+
  List of objects with pending SLA operations.
