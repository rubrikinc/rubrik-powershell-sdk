# New-RscQuerySonar
## Subcommands
### usergroups
- There are 5 arguments.
    - filter - ListAccessGroupsFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AccessGroupConnection.
### users
- There are 6 arguments.
    - sort - ListAccessUsersSortInput
    - filter - ListAccessUsersFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AccessUserConnection.
