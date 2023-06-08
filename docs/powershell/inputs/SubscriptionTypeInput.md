### SubscriptionTypeInput
Input for the event and audit types that the webhook is subscribed to.

- eventTypes: list of ActivityTypeEnums
  - Input for the event types that the webhook is subscribed to. If specified, IsSubscribedToAllEvents should be false.
- auditTypes: list of UserAuditTypeEnums
  - Input for the audit types that the webhook is subscribed to. If specified, IsSubscribedToAllAudits should be false.
- isSubscribedToAllEvents: System.Boolean
  - Specifies whether the webhook is subscribed to all events. If true, eventTypes should be empty.
- isSubscribedToAllAudits: System.Boolean
  - Specifies whether the webhook is subscribed to all audits. If true, auditTypes should be empty.
