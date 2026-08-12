# New-RscQueryPolicy
## Subcommands
### customtprpolicies
All unarchived custom TPR policies.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - TprPolicySortByField: Fields to sort TPR policies.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - TprPolicyFilterInput: Input for filtering a list of TPR policies.
- Returns CustomTprPolicyConnection.
### hapolicies
Queries high-availability policies for managing failover groups.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - HaPolicyFilter: Filters to apply to the query.
- Returns HaPolicyConnection.
### isvalidtprpolicyname
Validate the name of a TPR policy.

- There is a single argument of type System.String.
- Returns System.Boolean.
### orgsecuritypolicy
Organization security policy.

- The orgsecuritypolicy subcommand takes no arguments.
- Returns OrgSecurityPolicy.
### passwordcomplexitypolicy
Get the password complexity policy for the current organization.

- The passwordcomplexitypolicy subcommand takes no arguments.
- Returns PasswordComplexityPolicy.
### policies
Returns active policies for an account.

- There are 2 arguments.
    - policyObjectFilter - PolicyObjectFilter
    - excludeHierarchyObjectList - System.Boolean: Excludes hierarchy object IDs for each policy.
- Returns ClassificationPolicyDetailConnection.
### policy
Returns detailed policy information.

- There are 14 arguments.
    - policyId - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads used for filtering the query results.
    - sortBy - PolicyDetailsSortBy: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorts the order of results.
    - clusterIdsFilter - list of System.Strings: List of Rubrik clusters for filtering results.
    - replicationFilter - list of System.Strings: List of replication types for filtering results.
    - searchObjectName - System.String: Object name to search.
    - hierarchyAncestorIdFilter - System.String: Hierarchy ancestor ID.
    - policyAssignmentType - PolicyAssignmentType: Specifies whether the policy assignment type is direct or inherited.
    - includeDataTypeHits - System.Boolean: Include data type hits.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns ClassificationPolicyDetail.
### policycategories
The list of possible policy categories.

- There is a single argument of type list of PolicyTypes.
- Returns GetPossibleCategoriesType.
### policyfiltertypes
Get the list of possible types for selection for account.

- There are 3 arguments.
    - resourceType - PolicyResourceType: Resource type to filter by.
    - policyType - PolicyType: Policy type.
    - idpTypes - list of IdpTypes: Identity provider types to scope the filter types. If null, no scoping is applied. If empty list, returns cross-IDP filters only.
- Returns list of FilterTypes.
### policyfiltervalues
Get the list of possible values for selection for a policy filter.

- There are 5 arguments.
    - policyFilterType - FilterType: Policy filter type.
    - searchTerm - System.String: Search term to filter by.
    - policyType - PolicyType: Policy type.
    - policyTypeFilter - PolicyTypeFilter: Structured filter for policy-type-specific scoping (e.g., identity event providers).
    - eventProviders - list of EventProviders: DEPRECATED: use policyTypeFilter instead. List of identity event providers to scope the values.
- Returns GetPolicyFilterValuesType.
### policyframeworks
Get the list of possible policy frameworks.

- There is a single argument of type list of PolicyTypes.
- Returns list of System.Strings.
### policyobjectusages
Returns the policies assigned to each object.

- There is a single argument of type list of System.Strings.
- Returns PolicyObjectUsageConnection.
### policyrisksummaries
List of policy risk summaries for the requested policies on a given date.

- There are 3 arguments.
    - policyIds - list of System.Strings: Policy IDs whose risk summaries should be returned.
    - summaryDate - System.String: Date for which risk summaries are requested.
    - includeWhitelistedResults - System.Boolean: Specifies whether allowlisted results should be included.
- Returns list of PolicyRiskSummarys.
### policyviolationticketnumbers
Returns distinct ticket numbers (ServiceNow / Jira) associated
with policy violation remediations, optionally filtered by a
search term. When the search term is empty, the most recent
distinct ticket numbers are returned.

- There are 2 arguments.
    - policyTypes - list of PolicyTypes: Policy types to scope the ticket lookup.
    - searchTerm - System.String: Optional substring filter for ticket numbers.
When omitted, the most recent distinct ticket
numbers are returned.
- Returns list of System.Strings.
### securitypolicies
All security policies.

- There are 29 arguments.
    - isPolicyEnabled - System.Boolean: Is the policy enabled? If null, both enabled and disabled policies will be returned.
    - isCustomPolicy - System.Boolean: Is the policy custom, not built-in? If null, both custom and built-in policies will be returned.
    - policyCategories - list of Categorys: Policy categories to filter by. If empty or null, the results will not be filtered.
    - policySeverities - list of Severitys: Policy severities to filter by. If empty or null, the results will not be filtered.
    - includeViolationInsights - System.Boolean: Include violated hits.
    - policyIds - list of System.Strings: Policy IDs to filter by. If empty or null, the results will not be filtered.
    - resourceIds - list of System.Strings: Resource IDs to filter by. If empty or null, the results will not be filtered.
    - statuses - list of PolicyViolationStatuss: Policy violation statuses to filter by. If empty or null, the results will not be filtered.
    - statusReasons - list of PolicyViolationStatusReasons: Policy violation status reasons to filter by. If empty or null, the results will not be filtered.
    - policyViolationIds - list of System.Strings: Policy violation IDs to filter by. If empty or null, the results will not be filtered.
    - resourceTypes - list of PolicyResourceTypes: Resource types to filter by. If empty or null, the results will not be filtered.
    - sensitivityLevels - list of SensitivityLevels: Sensitivity levels to filter by. If empty or null, the results will not be filtered.
    - detectionDate - TimeRangeInput: Detection date range to filter by. If null, the results will not be filtered.
    - updateDate - TimeRangeInput: Violation update date range to filter by.
    - policyName - System.String: Policy name to filter by.
    - exactPolicyName - System.String: Exact policy name to filter by.
    - policyUpdateDate - TimeRangeInput: Policy update date range to filter by.
    - parentViolationId - System.String: Parent violation ID.
    - dataTypeIds - list of System.Strings: Data type IDs to filter.
    - documentTypeIds - list of System.Strings: Document type IDs to filter.
    - dataCategoryIds - list of System.Strings: Filter for data category IDs.
    - sortBy - PolicyViolationSortField: Field by which to sort policy violations.
    - sortOrder - SortOrder: Sort order for policy violations.
    - resourceMetadataFilter - ResourceMetadataFiltersInput: Resource metadata fields to filter by. If null, the results will not be filtered.
    - policyViolationNameSearch - System.String: Policy violation name to search for (substring match).
    - violationNames - list of System.Strings: Exact violation names to filter by. OR-combined with policyIds: a violation matches if its policyId is in policyIds OR its violationName is in violationNames. Distinct from policyViolationNameSearch (substring match, AND-combined).
    - policyFrameworks - list of System.Strings: Policy frameworks to filter by. If empty or null, the results will not be filtered.
    - idpTypes - list of IdpTypes: IdP (identity provider) types to filter policies by. If empty or null, the results will not be filtered.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
- Returns list of PolicyResults.
### securitypolicy
The full details of a policy and its definition.

- There are 3 arguments.
    - policyId - System.String: Policy ID.
    - includeViolationInsights - System.Boolean: Include violated hits.
    - policyType - PolicyType: Policy type.
- Returns PolicyResult.
### sidspolicyhitssummary
Returns the policy summary for security identifiers.

- There are 10 arguments.
    - sids - list of System.Strings: List of security identifiers.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
    - policyId - System.String: Policy id.
    - objectIdsFilter - list of System.Strings: Object IDs to filter.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sortBy - SidPolicySummarySortBy: Field on which to perform the sorting operation.
    - platformCategoryFilter - list of PlatformCategorys: Platform category to filter.
    - sortOrder - SortOrder: Sorts the order of results.
    - shouldCalculateAggregatedDataTypeLevelResults - System.Boolean: Specifies whether aggregated data type level results should be calculated.
- Returns SidsPolicyHitsSummaries.
### topriskpolicysummaries
Retrieve most risky policies.

- There are 3 arguments.
    - getWhitelistedResults - System.Boolean: Include whitelisted objects in the results.
    - limit - System.Int32: Maximum number of entries in the response.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
- Returns list of PolicySummarys.
### tprpolicydetail
Details for a TPR policy.

- There is a single argument of type System.String.
- Returns TprPolicyDetail.
