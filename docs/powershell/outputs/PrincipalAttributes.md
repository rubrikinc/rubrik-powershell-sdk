### PrincipalAttributes
PrincipalAttributes is one entry in the connection. The bag is
open-ended; different principal types expose different attributes,
and customer-extended AD schemas may add more.

- sid: System.String
  - Stable principal identifier (e.g. an AD SID).
- displayName: System.String
  - Human-readable name from userawareness_principals.name.
- principalType: PrincipalRiskySummaryPrincipalType
  - Principal type (USER, GROUP, COMPUTER, ...) from
userawareness_principals_version.principal_type.
- idpType: IdpType
  - Identity provider this principal belongs to (v1: typically
ON_PREM_AD).
- domain: System.String
  - Readable domain from userawareness_principals.entity_name
(e.g. "corp.example.com"). Empty when the source row has no
entity_name set.
- attributes: list of AttributeNameValuess
  - Open bag of directory attributes. Sensitive attributes
(nTSecurityDescriptor, sIDHistory) are stripped server-side.
Empty for principals whose IdP has no attribute sourcing in v1.
