### CreateWebhookInput
Webhook configuration to add to an account.

- description: System.String
  - A description of the webhook to be created.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- name: System.String
  - The name of the webhook to be created.
- url: System.String
  - The URL endpoint to the receiving application.
- subscriptionType: SubscriptionTypeInput
  - A list of event and audit types to which the webhook is subscribed.
- subscriptionSeverity: SubscriptionSeverityInput
  - A list of event and audit severities to which the webhook is subscribed.
- providerType: ProviderType
  - The application that will receive the webhook.
- authInfo: AuthInfoInput
  - The authentication type and token to authenticate the endpoint.
