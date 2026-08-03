### ViolationHistoryEventType
Type of event recorded in a violation's history timeline.

- HISTORY_EVENT_UNSPECIFIED - Unspecified event type.
- HISTORY_EVENT_CREATED - The violation was created (initial detection).
- HISTORY_EVENT_STATUS_CHANGED - The violation status was changed (e.g., open -> in-progress, dismissed).
- HISTORY_EVENT_REMEDIATION_TRIGGERED - A remediation was triggered against the violation.
- HISTORY_EVENT_REMEDIATION_COMPLETED - A remediation against the violation completed successfully.
- HISTORY_EVENT_REMEDIATION_FAILED - A remediation against the violation failed.
- HISTORY_EVENT_REMEDIATION_CLOSED - A remediation against the violation was closed (abandoned / no longer
applicable). Distinct from COMPLETED -- the remediation did not run to
success; it was terminated by the orchestrator or operator.
