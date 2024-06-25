### Passkey
Represents the webauthn passkey.

- passkeyName: System.String
  - Name of the passkey.
- createdAt: DateTime
  - Time at which passkey was created.
- userLastValidatedAt: DateTime
  - Last time at which user was validated using this passkey.
- credentialId: System.String
  - Credential ID as returned by authenticator.
- keyType: KeyTypeEnumType
  - Type of the passkey.
- os: System.String
  - OS on which passkey was created.
- browser: System.String
  - Browser on which passkey was created.
