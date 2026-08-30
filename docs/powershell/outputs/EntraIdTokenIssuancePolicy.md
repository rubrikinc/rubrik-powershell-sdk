### EntraIdTokenIssuancePolicy
Represents a token issuance policy.

- id: System.String
  - ID of the token issuance policy.
- displayName: System.String
  - Display name of the token issuance policy.
- signingAlgorithm: EntraIdTokenIssuanceSigningAlgorithm
  - Signing algorithm used to sign the SAML token.
- samlTokenVersion: System.String
  - Version of the SAML token.
- tokenResponseSigningPolicy: EntraIdTokenResponseSigningPolicy
  - Certificate signing option for the token response.
