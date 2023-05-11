### UpdateWebhookInput
Webhook configuration to update.

- authInfo: AuthInfoInput
  - The authentication type and token to authenticate the endpoint.
- description: System.String
  - A description of the webhook to be created.
- id: System.Int32
  - The ID of the webhook to be updated.
- name: System.String
  - The new name of the webhook to be updated.
- providerType: ProviderType
  - The application that will receive the webhook.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- shouldSendTestEvent: System.Boolean
  - Specifies whether a test event will be sent upon update.
- status: WebhookStatus
  - Specifies whether the webhook is enabled or not.
- subscriptionSeverity: SubscriptionSeverityInput
  - A list of event and audit severities to which the webhook is subscribed.
- subscriptionType: SubscriptionTypeInput
  - A list of event and audit types to which the webhook is subscribed.
- url: System.String
  - The URL endpoint to the receiving application.
