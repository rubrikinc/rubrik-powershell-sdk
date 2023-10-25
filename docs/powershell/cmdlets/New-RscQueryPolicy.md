# New-RscQueryPolicy
## Subcommands
### details
Returns active policies for an account.

- The details subcommand takes no arguments.
- Returns PolicyDetailConnection.
### obj
Returns details for one policy object.

- There are 3 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PolicyObj.
### objectusages
Returns the policies assigned to each object.

- There is a single argument of type list of System.Strings.
- Returns PolicyObjectUsageConnection.
### objs
Returns status for all objects at a specified timestamp.

- There are 20 arguments.
    - day - System.String: Day in the format (YYYY-MM-DD).
    - timezone - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - sortBy - System.String: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorting order for the results.
    - analysisStatusesFilter - list of AnalysisStatuss: List of analysis statuses used for filtering results.
    - policyIdsFilter - list of System.Strings: List of policies used for filtering results.
    - riskLevelsFilter - list of RiskLevelTypes: List of risk levels used for filtering results.
    - clusterIdsFilter - list of System.Strings: List of Rubrik clusters for filtering results.
    - searchObjectName - System.String: Object name to search.
    - subscriptionIdsFilter - list of System.Strings: List of subscriptions for filtering results.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sids - list of System.Strings: Filter for the given list of security identifiers.
    - insightsMetadataId - System.String: Filter objects with insights metadata ID.
    - includeInsightsMarker - System.Boolean: Specifies whether to include the insights marker.
    - userAccessObjectsFilter - System.Boolean: Filter objects with user access enabled.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns PolicyObjConnection.
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
