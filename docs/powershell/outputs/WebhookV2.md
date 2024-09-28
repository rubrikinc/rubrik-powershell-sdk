### WebhookV2
Webhook configuration to add to an account.

- id: System.Int32
  - The webhook's unique id.
- name: System.String
  - The name of the webhook to be created.
- createdBy: System.String
  - The user who created the webhook.
- description: System.String
  - A description of the webhook to be created.
- createdAt: DateTime
  - The timestamp that this webhook was created at.
- updatedAt: DateTime
  - The timestamp that this webhook was updated at.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- serviceAccountId: System.String
  - The ID of the service account attached to the webhook.
- url: System.String
  - The URL endpoint that will receive the webhook.
- providerType: ProviderTypeV2
  - The application that will receive the webhook.
- status: WebhookStatusV2
  - Specifies whether the webhook is enabled or not.
- authType: AuthenticationTypeV2
  - The authentication type that the endpoint uses.
- lastFailedErrorInfo: WebhookErrorInfo
  - The information describing the webhook's most recent error.
