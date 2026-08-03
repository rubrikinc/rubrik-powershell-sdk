### WebhookEncodedAuthInfoV2Input
The base64-encoded authentication type that the endpoint uses. Same shape
as AuthInfo; string values (token, credentials, header values) are standard
base64 of the UTF-8 bytes. SECURITY: base64 is encoding, NOT encryption --
these values are exactly as sensitive as the plain AuthInfo fields and are
protected only by TLS in transit and server-side encryption at rest. The
server decodes these into a plain AuthInfo before processing, so no
downstream type changes are required. When any encoded field is present on
the request, the request is in "encoded mode" and the plain auth_info is
ignored. Input-only -- never returned on any reply type.
EXCEPTION for oauth2_info: unlike the other fields (where every string
value is base64), only oauth2_info.client_secret is base64-encoded --
grant_type, token_url, client_id, scope, audience, resource, and
client_auth_method travel plain.

- authType: AuthenticationTypeV2
  - Authentication type that the endpoint uses (not encoded; it is an enum).
- token: System.String
  - Base64-encoded webhook authentication token. Auto-redacted in logs.
- userCredentials: UserCredentials
  - Authentication user credentials (username/password base64-encoded).
- customHeaders: list of CustomHeaders
  - Authentication request headers (header key/value base64-encoded).
- oauth2Info: WebhookOauth2InfoV2Input
  - OAuth 2.0 configuration, used when auth_type is OAUTH2. Only
client_secret is base64-encoded; see the message-level doc comment.
