### RemediationHistoryDetails
Remediation-specific details for a violation history entry.
Populated only for HISTORY_EVENT_REMEDIATION_* event types.

- remediationId: System.String
  - The ID of the remediation.
- remediationType: RemediationType
  - The type of remediation that was triggered.
- remediationState: RemediationState
  - The current state of the remediation.
