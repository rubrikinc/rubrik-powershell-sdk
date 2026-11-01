### AssignCloudDirectCopyScheduleReply
Per-share outcome of an assign operation. Each requested share has one
result, in request order, with a typed status for structured error
handling.

- results: list of CopyScheduleAssignShareResults
  - Results is one entry per input share_id, in input order.
