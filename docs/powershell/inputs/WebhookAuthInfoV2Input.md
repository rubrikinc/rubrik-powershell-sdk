### WebhookAuthInfoV2Input
The authentication type that the endpoint uses.

- authType: AuthenticationTypeV2
  - Authentication type that the endpoint uses.
- token: System.String
  - Webhook authentication token. Auto-redacted in logs.
- userCredentials: UserCredentials
  - Authentication user credentials.
- customHeaders: list of CustomHeaders
  - Authentication req headers.
- oauth2Info: WebhookOauth2InfoV2Input
  - OAuth 2.0 configuration, used when auth_type is OAUTH2.
