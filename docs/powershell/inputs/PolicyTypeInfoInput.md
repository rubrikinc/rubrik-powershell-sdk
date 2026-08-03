### PolicyTypeInfoInput
Carries policy-type-specific configuration. The oneof allows future policy
types to add their own info messages without schema changes.

- identityEventPolicyInfo: IdentityEventPolicyInfoInput
  - Configuration for identity event policies.
- identityPolicyInfo: IdentityPolicyInfoInput
  - Configuration for identity policies.
- idpPolicyInfo: IdpPolicyInfoInput
  - Configuration for IDP policies.
- signinAnomalyPolicyInfo: SigninAnomalyPolicyInfoInput
  - Configuration for sign-in anomaly policies.
