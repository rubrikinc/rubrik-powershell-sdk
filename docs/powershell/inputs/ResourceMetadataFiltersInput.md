### ResourceMetadataFiltersInput
Resource metadata fields to filter by.

- objectTypes: list of DataGovObjectTypes
  - The list of object types to filter by. If empty, the results
will not be filtered.
- cloudAccountIds: list of System.Strings
  - The list of cloud account IDs to filter by. If empty, the results will not be filtered.
- managedObjectTypes: list of ManagedObjectTypes
  - The list of managed object types to filter by. If empty, the results will not be filtered.
- principalTypes: list of ViolationPrincipalTypes
  - The list of principal/identity types to filter by. If empty, the results will not be filtered.
- resolutionTypes: list of IdentityResolutionTypes
  - The list of resolution types/origin to filter by. If empty, the results will not be filtered.
- domainFids: list of System.Strings
  - The list of domain FIDs to filter by. If empty, the results will not be filtered.
- identityNameSearch: System.String
  - The identity name to search for. If empty, the results will not be filtered.
- accessTypes: list of AccessVias
  - The list of access types to filter by. If empty, the results will not be filtered.
- sources: list of System.Strings
  - The list of sources to filter by. If empty, the results will not be filtered.
- idpTypes: list of IdpTypes
  - The list of identity provider types to filter by. If empty, the results will not be filtered.
- originEventDateRange: TimeRangeInput
  - The date range of the origin event to filter by. If empty, the results will not be filtered.
- identityTags: list of IdentityTags
  - The identity tags to filter by. If empty, the results will not be filtered.
- actorIds: list of System.Strings
  - The actor identity IDs to filter by. If empty, the results will not be filtered.
- identityOrigins: list of PrincipalOrigins
  - Filter by identity origin (INTERNAL/EXTERNAL).
