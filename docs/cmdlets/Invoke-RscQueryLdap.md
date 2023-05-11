# Invoke-RscQueryLdap
## Subcommands
### AuthorizedPrincipalList
Browse LDAP-authorized principals.

- The Input parameter takes a hashtable with 8 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - roleIds - a list of System.Strings: Assigned role IDs for LDAP principal.
    - searchText - System.String: Search Text for LDAP principal.
    - sortBy - LdapAuthorizedPrincipalFieldEnum
    - sortOrder - SortOrder: Sorting order for the results.
- Returns AuthorizedPrincipalConnection.
### IntegrationList
Browse LDAP integrations.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - LdapIntegrationFieldEnum
    - sortOrder - SortOrder: Sorting order for the results.
- Returns LdapIntegrationConnection.
### PrincipalList
Search LDAP Principals.

- The Input parameter takes a hashtable with 8 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - id - System.String: ID for your LDAP integration.
    - last - System.Int32: Returns the last n elements from the list.
    - searchText - System.String: Search Text for LDAP principal.
    - sortBy - LdapPrincipalFieldEnum
    - sortOrder - SortOrder: Sorting order for the results.
- Returns PrincipalConnection.
