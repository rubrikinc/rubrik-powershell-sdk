### SsoRecoveryOptionInput
SsoRecoveryOption controls recovery of the SSO objects linked to the
selected service principals and applications.

- ssoSigningCertConfigs: list of SsoSigningCertConfigInputs
  - Specifies the per-object signing certificate configs uploaded by the user.
- ssoSigningCertExpiryTime: DateTime
  - Specifies the expiry time to apply to restored SSO signing certificates.
- shouldRecoverLinkedSsoPolicies: System.Boolean
  - When true, recovers all linked SSO policies (token issuance, token lifetime, claims mapping, and home realm discovery) for the selected objects.
