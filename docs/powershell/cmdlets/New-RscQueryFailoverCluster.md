# New-RscQueryFailoverCluster
## Subcommands
### app
Get details of the given failover cluster app.

- There is a single argument of type System.String.
- Returns FailoverClusterApp.
### apps
Get a summary of all failover cluster apps.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - hostFailoverClusterRoot - HostFailoverClusterRoot: Host failover cluster root type.
- Returns FailoverClusterAppConnection.
### host
Get details of the given host failover cluster.

- There is a single argument of type System.String.
- Returns HostFailoverCluster.
### hosts
Get a summary of all host failover clusters.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - hostFailoverClusterRoot - HostFailoverClusterRoot: Host failover cluster root type.
- Returns HostFailoverClusterConnection.
### topleveldescendants
Get a summary of all failover cluster top level descendants.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
    - hostFailoverClusterRoot - HostFailoverClusterRoot: Host failover cluster root type.
- Returns FailoverClusterTopLevelDescendantTypeConnection.
