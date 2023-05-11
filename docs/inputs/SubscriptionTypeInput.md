### SubscriptionTypeInput
Input for the event and audit types that the webhook is subscribed to.

- auditTypes: a list of UserAuditTypeEnums
  - Input for the audit types that the webhook is subscribed to. If specified, IsSubscribedToAllAudits should be false.
- eventTypes: a list of ActivityTypeEnums
  - Input for the event types that the webhook is subscribed to. If specified, IsSubscribedToAllEvents should be false.
- isSubscribedToAllAudits: System.Boolean
  - Specifies whether the webhook is subscribed to all audits. If true, auditTypes should be empty.
- isSubscribedToAllEvents: System.Boolean
  - Specifies whether the webhook is subscribed to all events. If true, eventTypes should be empty.
