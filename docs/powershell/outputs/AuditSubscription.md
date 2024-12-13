### AuditSubscription
The audit subscription information.

- isSubscribedToAllAudits: System.Boolean
  - True if subscribed to all audits.
- isSubscribedToAllObjectTypes: System.Boolean
  - True if subscribed to all object types.
- templateInfo: TemplateInfo
  - Subscription message template.
- auditTypes: list of AuditTypes
  - The audit types to which the webhook is subscribed.
- objectTypes: list of AuditObjectTypes
  - The object types to which the webhook is subscribed.
- severities: list of AuditSeveritys
  - The audit severities to which the webhook is subscribed.
