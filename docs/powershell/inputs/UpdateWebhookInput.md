### UpdateWebhookInput
Webhook configuration to update.

- name: System.String
  - The new name of the webhook to be updated.
- description: System.String
  - A description of the webhook to be created.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- id: System.Int32
  - The ID of the webhook to be updated.
- subscriptionType: SubscriptionTypeInput
  - A list of event and audit types to which the webhook is subscribed.
- subscriptionSeverity: SubscriptionSeverityInput
  - A list of event and audit severities to which the webhook is subscribed.
- providerType: ProviderType
  - The application that will receive the webhook.
- authInfo: AuthInfoInput
  - The authentication type and token to authenticate the endpoint.
- status: WebhookStatus
  - Specifies whether the webhook is enabled or not.
- url: System.String
  - The URL endpoint to the receiving application.
- shouldSendTestEvent: System.Boolean
  - Specifies whether a test event will be sent upon update.
