### CopyScheduleUnassignResult
Per-assignment outcome of an unassign operation.

- assignmentId: System.String
  - Assignment ID echoes the input assignment identifier so callers can
correlate results without depending on list order.
- status: ShareUnassignStatus
  - Status is the unassign outcome for this assignment.
- errorMessage: System.String
  - Error message provides detail when status is not SUCCESS.
