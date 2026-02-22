### WebhookEventSubscriptionInput
Event subscription settings.

- eventTypes: list of EventTypes
  - The event types to subscribe to.
- objectTypes: list of EventObjectTypes
  - The object types to subscribe to.
- severities: list of EventSeveritys
  - The severity levels to subscribe to.
- isSubscribedToAllEvents: System.Boolean
  - Whether the webhook is subscribed to all events.
- isSubscribedToAllObjectTypes: System.Boolean
  - Whether the webhook is subscribed to all object types.
- templateInfo: WebhookTemplateInfoInput
  - The template information.
