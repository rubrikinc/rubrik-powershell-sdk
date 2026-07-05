### WebhookPayload
Webhook configuration information.

- name: System.String
  - The name of the webhook to be created.
- url: System.String
  - Webhook receiver url.
- providerType: ProviderTypeV2
  - Webhook integration provider type.
- authInfo: WebhookAuthInfoV2Input
  - Authentication type that the endpoint uses. Optional: a request may
instead supply auth in encoded form. A request must be EITHER fully plain
(url + auth_info) OR fully encoded (encoded_url + encoded_auth_info);
mixing plain and encoded fields is rejected (enforced server-side).
- subscriptionType: WebhookSubscriptionTypeV2Input
  - Webhook subscription settings.
- description: System.String
  - A description of the webhook to be created.
- serverCertificate: System.String
  - The Webhook server certificate that Rubrik uses to establish a TLS connection with the endpoint.
- serviceAccountId: System.String
  - The ID of the service account attached to the webhook.
- encodedUrl: System.String
  - Base64-encoded webhook receiver url. Optional alternative to `url`.
When any encoded field is present, the request is in encoded mode and the
plain `url` is ignored. SECURITY: base64 is not encryption.
- encodedAuthInfo: WebhookEncodedAuthInfoV2Input
  - Base64-encoded authentication info. Optional alternative to `auth_info`.
When any encoded field is present, the request is in encoded mode and the
plain `auth_info` is ignored. Input-only; never returned on a reply.
