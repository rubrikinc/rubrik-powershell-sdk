### WebhookAuditSubscriptionInput
Audit subscription settings.

- isSubscribedToAllAudits: System.Boolean
  - Whether the webhook is subscribed to all audits.
- isSubscribedToAllObjectTypes: System.Boolean
  - Whether the webhook is subscribed to all object types.
- auditTypes: list of AuditTypes
  - The audit types to subscribe to.
- objectTypes: list of AuditObjectTypes
  - The object types to subscribe to.
- severities: list of AuditSeveritys
  - The severity levels to subscribe to.
- templateInfo: WebhookTemplateInfoInput
  - The template information.
