# New-RscQueryServiceAccount
## Subcommands
### isorgdisabled
Returns whether the service accounts of the organization are not enabled.

- The isorgdisabled subcommand takes no arguments.
- Returns System.Boolean.
### serviceaccount
Browse service accounts.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - ServiceAccountSortBy: Service account argument to sort by.
    - searchText - System.String: Search for a service account.
    - roleIds - list of System.Strings: Assigned role IDs for service account.
- Returns ServiceAccountConnection.
