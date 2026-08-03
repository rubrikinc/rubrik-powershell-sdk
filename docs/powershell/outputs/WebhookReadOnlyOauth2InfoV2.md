### WebhookReadOnlyOauth2InfoV2
Read-only projection of OAuth2Info returned in webhook query responses.
Never includes the client secret.

- grantType: WebhookOauth2GrantTypeV2
  - The OAuth 2.0 grant type configured. Only CLIENT_CREDENTIALS is supported.
- tokenUrl: System.String
  - The configured token endpoint.
- clientId: System.String
  - The configured public client identifier.
- scope: System.String
  - The configured scope, if any.
- audience: System.String
  - The configured audience, if any.
- resource: System.String
  - The configured RFC 8707 resource indicator, if any.
- clientAuthMethod: WebhookOauth2ClientAuthMethodV2
  - How client credentials are presented to the token endpoint.
