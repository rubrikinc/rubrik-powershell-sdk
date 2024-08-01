# New-RscQueryPolicy
## Subcommands
### customtprpolicies
All unarchived custom TPR policies.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - TprPolicySortByField: Fields to sort TPR policies.
    - sortOrder - SortOrder: Sort order of result.
    - filter - TprPolicyFilterInput: Input for filtering a list of TPR policies.
- Returns CustomTprPolicyConnection.
### isvalidtprpolicyname
Validate the name of a TPR policy.

- There is a single argument of type System.String.
- Returns System.Boolean.
### orgsecuritypolicy
Organization security policy.

- The orgsecuritypolicy subcommand takes no arguments.
- Returns OrgSecurityPolicy.
### passwordcomplexitypolicy
Get the password policy for the current organization.

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

- There are 13 arguments.
    - policyId - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads used for filtering the query results.
    - sortBy - PolicyDetailsSortBy: Name of the column to sort result by.
    - sortOrder - SortOrder: Sort order of result.
    - clusterIdsFilter - list of System.Strings: List of Rubrik clusters for filtering results.
    - replicationFilter - list of System.Strings: List of replication types for filtering results.
    - searchObjectName - System.String: Object name to search.
    - hierarchyAncestorIdFilter - System.String: Hierarchy ancestor ID.
    - policyAssignmentType - PolicyAssignmentType: Specifies whether the policy assignment type is direct or inherited.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ClassificationPolicyDetail.
### policyobjectusages
Returns the policies assigned to each object.

- There is a single argument of type list of System.Strings.
- Returns PolicyObjectUsageConnection.
### policyrisksummaries
List of policy risk summaries.

- There are 3 arguments.
    - policyIds - list of System.Strings
    - summaryDate - System.String
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns list of PolicyRiskSummarys.
### sidspolicyhitssummary
Return policy summary for security identifiers.

- There are 7 arguments.
    - sids - list of System.Strings: List of security identifiers.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - historicalDeltaDays - System.Int32: Historical days to go backward in time to calculate the delta.
    - policyId - System.String: Policy id.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sortBy - SidPolicySummarySortBy: Field on which to perform the sorting operation.
    - sortOrder - SortOrder: Sort order of result.
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
