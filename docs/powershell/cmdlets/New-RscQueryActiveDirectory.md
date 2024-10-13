# New-RscQueryActiveDirectory
## Subcommands
### domain
Summary of the given Active Directory domain.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomain.
### domaincontroller
Summary of the given Active Directory domain controller.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomainController.
### domaincontrollers
Summary of all Active Directory domain controllers.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ActiveDirectoryDomainControllerConnection.
### domains
Summary of all Active Directory domains.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ActiveDirectoryDomainConnection.
### searchsnapshots
Search across a range of snapshots of a domain controller for Active Directory objects

Supported in v9.1+
Return the Active Directory objects matching the search criteria.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - id - System.String: ID of the Active Directory domain controller that needs to be explored.
    - snapshotAfterDate - DateTime: Searches across the snapshots taken on or after the specified date.
    - snapshotBeforeDate - DateTime: Searches across the snapshots taken on or before the specified date.
    - name - System.String: Search string.
    - activeDirectoryObjectType - ActiveDirectoryObjectType: The supported Active Directory object types.
- Returns ActiveDirectorySnappableSearchResponseConnection.
