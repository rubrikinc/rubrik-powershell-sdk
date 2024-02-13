# New-RscQueryPolicy
## Subcommands
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
    - sortOrder - SortOrder: Sorting order for the results.
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
### topriskpolicysummaries
Retrieve most risky policies.

- There are 3 arguments.
    - getWhitelistedResults - System.Boolean: Include whitelisted objects in the results.
    - limit - System.Int32: Maximum number of entries in the response.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
- Returns list of PolicySummarys.
