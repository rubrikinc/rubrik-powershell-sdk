### PrincipalMetadataFiltersInput
Principal-scoped filters for narrowing policy violations by attributes
of the principal (identity) involved.

- principalTypes: list of ViolationPrincipalTypes
  - List of principal/identity types to filter by.
- identityOrigins: list of PrincipalOrigins
  - Filter by identity origin (INTERNAL/EXTERNAL).
- idpTypes: list of IdpTypes
  - List of identity providers to filter by.
- sources: list of System.Strings
  - List of sources to filter by.
- identityNameSearch: System.String
  - Search term to filter identities by name (substring match).
