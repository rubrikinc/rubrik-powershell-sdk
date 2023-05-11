### CreateWebhookInput
Webhook configuration to add to an account.

- authInfo: AuthInfoInput
  - The authentication type and token to authenticate the endpoint.
- description: System.String
  - A description of the webhook to be created.
- name: System.String
  - The name of the webhook to be created.
- providerType: ProviderType
  - The application that will receive the webhook.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- subscriptionSeverity: SubscriptionSeverityInput
  - A list of event and audit severities to which the webhook is subscribed.
- subscriptionType: SubscriptionTypeInput
  - A list of event and audit types to which the webhook is subscribed.
- url: System.String
  - The URL endpoint to the receiving application.
