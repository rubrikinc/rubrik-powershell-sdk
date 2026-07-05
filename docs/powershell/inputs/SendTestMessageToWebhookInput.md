### SendTestMessageToWebhookInput
The input values for sending test message to webhook.

- url: System.String
  - Webhook receiver url.
- providerType: ProviderTypeV2
  - Webhook integration provider type.
- authInfo: WebhookAuthInfoV2Input
  - Authentication type that the endpoint uses. Optional (was REQUIRED): a
request may instead supply encoded_auth_info.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- encodedUrl: System.String
  - Base64-encoded webhook receiver url. Optional alternative to `url`.
- encodedAuthInfo: WebhookEncodedAuthInfoV2Input
  - Base64-encoded authentication info. Optional alternative to `auth_info`.
