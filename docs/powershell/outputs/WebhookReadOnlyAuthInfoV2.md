### WebhookReadOnlyAuthInfoV2
Read-only authentication metadata returned in webhook query responses.
Contains only non-sensitive fields. Sensitive values (password, token,
header values, client secret) are never included.

- username: System.String
  - The username for basic authentication, if configured.
- headerKeys: list of System.Strings
  - The custom header key names, if custom header auth is configured.
- oauth2Info: WebhookReadOnlyOauth2InfoV2
  - Read-only OAuth 2.0 configuration, if OAuth 2.0 auth is configured.
