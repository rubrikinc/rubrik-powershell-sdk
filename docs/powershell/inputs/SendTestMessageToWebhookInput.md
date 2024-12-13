### SendTestMessageToWebhookInput
The input values for sending test message to webhook.

- url: System.String
  - Webhook receiver url.
- providerType: ProviderTypeV2
  - Webhook integration provider type.
- authInfo: WebhookAuthInfoV2Input
  - Authentication type that the endpoint uses.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
