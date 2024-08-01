### CreatePasskeyInput
Input required for creating a passkey.

- additionalConfig: System.String
  - Optional. Any additional setup or context for the passkey that may be needed for advanced functionality.
- os: System.String
  - Optional. Operating system using which the passkey is generated.
- browser: System.String
  - Optional. Browser using which the passkey is generated.
- credentialId: System.String
  - Required. ID of the passkey credential returned by the browser.
- passkeyName: System.String
  - Required. Name of the passkey as provided by user.
- publicKey: System.String
  - Required. Public key connected to the passkey credential, as provided by the user's authenticator.
- keyType: KeyTypeEnumType
  - Required. The type of the passkey (platform or roaming).
- clientData: System.String
  - Required. Client-side data used during the generation of the WebAuthn passkey.
- authData: System.String
  - Required. Contains the authenticator data that verifies user's authenticity during the generation of a passkey.
