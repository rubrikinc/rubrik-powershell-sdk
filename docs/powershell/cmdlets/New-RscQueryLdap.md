# New-RscQueryLdap
## Subcommands
### authorizedprincipallist
Browse LDAP-authorized principals.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapAuthorizedPrincipalFieldEnum
    - searchText - System.String: Search Text for LDAP principal.
    - roleIds - list of System.Strings: Assigned role IDs for LDAP principal.
- Returns AuthorizedPrincipalConnection.
### integrationlist
Browse LDAP integrations.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapIntegrationFieldEnum
- Returns LdapIntegrationConnection.
### principallist
Search LDAP Principals.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - LdapPrincipalFieldEnum
    - id - System.String: ID for your LDAP integration.
    - searchText - System.String: Search Text for LDAP principal.
- Returns PrincipalConnection.
