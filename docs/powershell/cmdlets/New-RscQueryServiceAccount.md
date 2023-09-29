# New-RscQueryServiceAccount
## Subcommands
### serviceaccount
Browse service accounts.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - ServiceAccountSortBy: Service account argument to sort by.
    - searchText - System.String: Search for a service account.
    - roleIds - list of System.Strings: Assigned role IDs for service account.
- Returns ServiceAccountConnection.
