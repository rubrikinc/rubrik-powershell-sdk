### TestWebhookInput
Webhook configuration to test.

- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- providerType: ProviderType
  - The application that will receive the webhook.
- authInfo: AuthInfoInput
  - The authentication type and token to authenticate the endpoint.
- url: System.String
  - The URL endpoint to the receiving application.
