### ViolationHistoryEntry
A single entry in a policy violation's history timeline.

- timestamp: DateTime
  - Timestamp at which the event occurred.
- eventType: ViolationHistoryEventType
  - Type of event this entry represents.
- actorName: System.String
  - User who performed the action.
- details: ViolationHistoryDetailsUnion
  - Per-event-type details. Unset for HISTORY_EVENT_CREATED.
