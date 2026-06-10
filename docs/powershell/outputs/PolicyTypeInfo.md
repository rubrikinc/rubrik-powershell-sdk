### PolicyTypeInfo
Carries policy-type-specific configuration. The oneof allows future policy
types to add their own info messages without schema changes.

- identityEventPolicyInfo: IdentityEventPolicyInfo
  - Configuration for identity event policies.
- identityPolicyInfo: IdentityPolicyInfo
  - Configuration for identity policies.
- idpPolicyInfo: IdpPolicyInfo
  - Configuration for IDP policies.
