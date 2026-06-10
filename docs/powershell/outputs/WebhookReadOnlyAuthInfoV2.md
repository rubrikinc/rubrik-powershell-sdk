### WebhookReadOnlyAuthInfoV2
Read-only authentication metadata returned in webhook query responses.
Contains only non-sensitive fields. Sensitive values (password, token,
header values) are never included.

- username: System.String
  - The username for basic authentication, if configured.
- headerKeys: list of System.Strings
  - The custom header key names, if custom header auth is configured.
