### WebhookIdentityActivitySubscriptionInput
Identity activity subscription settings.
When this field is provided, the webhook is subscribed to identity
activity events. When omitted, the webhook does not receive them.

- templateInfo: WebhookTemplateInfoInput
  - The template information.
- actionTypes: list of LambdaEventActionTypes
  - Action types to include. Empty list = deliver all action types.
- activityProviders: list of EventProviders
  - Identity providers to include. Empty list = deliver from all providers.
