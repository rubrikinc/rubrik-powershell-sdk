### ModifyIdentityProviderInput
Attributes to add for an organization's identity provider.

- idpId: System.String
  - ID of the identity provider.
- name: System.String
  - Name of the identity provider.
- entityId: System.String
  - Entity ID of the identity provider.
- signInUrl: System.String
  - Sign-in URL for the identity provider.
- signingCertificate: System.String
  - Signing certificate for the identity provider.
- isDefault: System.Boolean
  - Specifies if the identity provider should be set as the default.
- idpClaimAttributes: list of IdpClaimAttributes
  - Custom claims for the identity provider.
