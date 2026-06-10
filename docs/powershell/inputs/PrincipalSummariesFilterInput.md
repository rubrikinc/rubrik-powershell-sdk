### PrincipalSummariesFilterInput
Filter to be applied when retrieving principal summaries.

- principalType: PrincipalRiskySummaryPrincipalType
  - Principal type to filter on.
- riskLevel: list of RiskLevelTypes
  - Filter by risk levels.
- principalName: System.String
  - Principal name to filter on.
- sids: list of System.Strings
  - Sids to filter on.
- objectIds: list of System.Strings
  - Object IDs to filter on.
- groupId: System.String
  - Group ID to filter principals by.
- previousRiskLevel: list of RiskLevelTypes
  - Filter by previous risk levels.
- privilegeTypesFilter: list of PrivilegeTypes
  - Filter by privilege type of principal.
- idpTypesFilter: list of IdpTypes
  - Filter by source of principal.
- domainFidsFilter: list of System.Strings
  - Filter by domain FID of principal.
- title: list of System.Strings
  - Filter by title of principal.
- cloudAccountIds: list of System.Strings
  - Filter by cloud account IDs of principal.
- dataTypeIds: list of System.Strings
  - Filter principals by the data types they have access to.
- violationSeverity: list of ViolationSeveritys
  - Filter by severity of violations.
- featureFilter: PrincipalFeature
  - Filter by feature.
- statusFilter: PrincipalStatus
  - Filter by principal status.
- entityIds: list of System.Strings
  - Filter by entity IDs of principal.
- principalTypes: list of PrincipalRiskySummaryPrincipalTypes
  - Principal types to filter on.
- principalOrigins: list of PrincipalOrigins
  - Principal origins to filter by.
- directParentOfPrincipal: System.String
  - Filter to return principals that are direct parents of the specified
principal.
- accessTypeFilter: list of AccessVias
  - Indicates the type of accesses an identity should have on an object.
- identityTags: list of IdentityTags
  - Filter by identity tags.
- identityStatusFilter: list of IdentityStatuss
  - Filter by status.
- nativeTypes: list of NativeTypes
  - Filter by native type.
- newlyAdded: System.Boolean
  - Filter newly added identities.
- entraMfaStrength: list of MfaStrengths
  - Filter by MFA strength for Entra principals.
- linkedPrincipalId: System.String
  - Filter by linked principal ID.
- ownerPrincipalIds: list of System.Strings
  - Filter by owner principal IDs.
- includeDeletedPrincipals: System.Boolean
  - Specifies whether to include deleted principals in the response.
- gpoStatusFilter: list of GpoStatusEnums
  - Filter by GPO status. Only applicable when principal_types includes GPO.
- gpoLinkingStatusFilter: list of GPOLinkingStatusEnums
  - Filter by GPO linking status. Proto field added in P0 but NOT exposed
in GraphQL schema until P1 when linking computation is implemented.
- departments: list of System.Strings
  - Filter principals by one or more department values. Returns only
principals whose department exactly matches one of the provided values.
- editorsForGpo: System.String
  - Filter to return principals that are editors of the specified GPO
principal. AND-combines with all other filters in this message.
An empty value means the filter is inactive. A value that does not
identify a GPO with at least one editor returns an empty page.
- policyIds: list of System.Strings
  - Policy ids to filter on.
- nativeCreationTime: TimeRangeInput
  - Filter by native creation time range.
- principalSummaryCategory: PrincipalSummaryCategoryType
  - Principal summary category.
