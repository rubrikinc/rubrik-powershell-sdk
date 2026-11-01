### UnassignCloudDirectCopyScheduleReply
Per-assignment outcome of an unassign operation. Each requested
assignment has one result, in request order, with a typed status for
structured error handling.

- results: list of CopyScheduleUnassignResults
  - Results is one entry per input assignment_id, in input order.
