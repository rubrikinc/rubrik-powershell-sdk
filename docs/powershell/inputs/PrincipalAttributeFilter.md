### PrincipalAttributeFilter
PrincipalAttributeFilter narrows the principals returned by
ListPrincipalAttributes. Filtering by attribute name or value is
explicitly not supported; the full attribute bag (minus the security
deny-list) is always returned per principal.

- idpTypes: list of IdpTypes
  - Restrict to specific identity providers. Empty = all in-scope IdPs.
v1: only ON_PREM_AD principals carry populated attributes; pass
[ON_PREM_AD] if non-empty bags are required.
- principalTypes: list of PrincipalRiskySummaryPrincipalTypes
  - Restrict to specific principal types (USER, GROUP, COMPUTER, ...).
Empty = all in-scope types. Out-of-range values are rejected.
DNS_ZONE and DNS_NODE are always excluded server-side regardless
of this filter.
- domains: list of System.Strings
  - Restrict to specific domains. Empty = all in-scope domains.
Matched against userawareness_principals.entity_name (a readable
name such as "corp.example.com") -- same source as the response
`domain` field. Rows with NULL entity_name never match.
- searchTerm: System.String
  - Prefix match against principal display name OR SID
(case-insensitive per MySQL collation; %/_ escaped server-side;
length-bounded). Substring/contains matches are not supported.
- shouldIncludeDeleted: System.Boolean
  - When false (default), deleted principals are excluded. Set to true to
include them.
