# New-RscQueryCrossAccount
## Subcommands
### crossaccountclusters
List all cross-account clusters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filter - list of GetCrossAccountClustersFilters: Specification on how to filter a list of cross-account clusters.
    - sortBy - GetCrossAccountClustersSortByField: Specifies the field by which the list of cross-account clusters will be sorted.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns CrossAccountClusterConnection.
