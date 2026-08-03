### WebhookOauth2InfoV2Input
OAuth 2.0 configuration. Today only the client-credentials grant is used.

- grantType: WebhookOauth2GrantTypeV2
  - The OAuth 2.0 grant type to use. Only CLIENT_CREDENTIALS is supported.
- tokenUrl: System.String
  - The token endpoint that the service calls to obtain an access token.
Must use HTTPS. This field is required.
- clientId: System.String
  - The public client identifier (not a secret).
- clientSecret: System.String
  - The client secret. Auto-redacted in logs.
- scope: System.String
  - Optional space-separated scope list (e.g. "api:read api:write").
- audience: System.String
  - Optional target-API audience. Required by Auth0/Okta M2M to mint a usable
API token; without it those providers error or return a wrongly-scoped
token. Sent as the `audience` form param when set (not a secret).
- resource: System.String
  - Optional RFC 8707 resource indicator (target API URL). Sent as the
`resource` form param when set. It is an alternative to audience for
RFC-8707 IdPs.
- clientAuthMethod: WebhookOauth2ClientAuthMethodV2
  - How to present client credentials to the token endpoint. Default (unset)
is CLIENT_SECRET_POST. Set CLIENT_SECRET_BASIC for IdPs that require it.
