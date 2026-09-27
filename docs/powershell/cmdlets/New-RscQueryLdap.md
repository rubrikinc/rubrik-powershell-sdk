# New-RscQueryLdap
## Subcommands
### authorizedprincipallist
Browse LDAP-authorized principals.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - searchText - System.String: Search Text for LDAP principal.
    - roleIds - list of System.Strings: Assigned role IDs for LDAP principal.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapAuthorizedPrincipalFieldEnum: Field to sort LDAP authorized principals by.
- Returns AuthorizedPrincipalConnection.
### integrationlist
Browse LDAP integrations.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapIntegrationFieldEnum: Field to sort LDAP integrations by.
- Returns LdapIntegrationConnection.
### principallist
Search LDAP Principals.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - id - System.String: ID for your LDAP integration.
    - searchText - System.String: Search Text for LDAP principal.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapPrincipalFieldEnum: Field to sort LDAP principals by.
- Returns PrincipalConnection.
