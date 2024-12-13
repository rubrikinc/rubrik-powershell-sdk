### WebhookPayload
Webhook configuration information.

- name: System.String
  - The name of the webhook to be created.
- url: System.String
  - Webhook receiver url.
- providerType: ProviderTypeV2
  - Webhook integration provider type.
- authInfo: WebhookAuthInfoV2Input
  - Authentication type that the endpoint uses.
- subscriptionType: WebhookSubscriptionTypeV2Input
  - Webhook subscription settings.
- description: System.String
  - A description of the webhook to be created.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- serviceAccountId: System.String
  - The ID of the service account attached to the webhook.
