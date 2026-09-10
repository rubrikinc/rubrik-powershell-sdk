### EntraIdTokenResponseSigningPolicy
Certificate signing option of a token issuance policy.

- ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_UNKNOWN - Default zero value. Indicates the signing policy was not set
or did not match any known Microsoft Graph value.
- ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_ONLY - Only the SAML response is signed.
- ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_TOKEN_ONLY - Only the SAML token is signed.
- ENTRA_ID_TOKEN_RESPONSE_SIGNING_POLICY_RESPONSE_AND_TOKEN - Both the SAML response and the token are signed.
