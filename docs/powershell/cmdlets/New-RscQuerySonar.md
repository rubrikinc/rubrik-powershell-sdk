# New-RscQuerySonar
## Subcommands
### usergroups
Returns a paginated list of user groups visible in the user awareness
experience.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filter - ListAccessGroupsFilterInput: Optional filter to narrow the returned groups by name or user.
- Returns AccessGroupConnection.
### users
Endpoints for Users list page
Returns a paginated list of access users discovered by classification.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filter - ListAccessUsersFilterInput: Optional filter to narrow the returned users by group or name.
    - sort - ListAccessUsersSortInput: Optional sort criteria for the returned users.
- Returns AccessUserConnection.
