### OnPremAdPrincipalMetadata
On-prem AD principal metadata.

- mgdPasswdInterval: System.Int32
  - Managed password interval in days for password rotation of the principal.
- supEncTypes: list of OnPremAdSupportedEncryptionTypess
  - Supported encryption types for the principal.
- isPasswordCompliant: System.Boolean
  - Determines if the principal is password compliant.
- managedBy: list of System.Strings
  - Specifies the identities that can manage this principal.
- onpremAdPrincipalTypeSpecificMetadata: OnPremAdPrincipalTypeSpecificMetadata
  - Represents on-prem AD principal type specific metadata.
