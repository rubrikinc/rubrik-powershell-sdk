### ViolationStatusHistoryDetails
Status-change-specific details for a violation history entry.
Populated only for HISTORY_EVENT_STATUS_CHANGED event type.

- previousStatus: PolicyViolationStatus
  - Previous status of the violation.
- newStatus: PolicyViolationStatus
  - New status of the violation.
- statusChangeReason: PolicyViolationStatusReason
  - Reason associated with the status change.
