# New-RscQueryNas
## Subcommands
### clouddirectnassystem
Cloud Direct NAS system.

- There is a single argument of type System.String.
- Returns CloudDirectNasSystem.
### clouddirectnassystems
Paginated list of Cloud Direct NAS systems.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns CloudDirectNasSystemConnection.
### fileset
A NAS Fileset.

- There is a single argument of type System.String.
- Returns NasFileset.
### namespace
A NAS Namespace.

- There is a single argument of type System.String.
- Returns NasNamespace.
### namespaces
Paginated list of NAS Namespaces.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NasNamespaceConnection.
### share
A NAS Share.

- There is a single argument of type System.String.
- Returns NasShare.
### shares
Paginated list of NAS Shares.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NasShareConnection.
### system
A NAS System.

- There is a single argument of type System.String.
- Returns NasSystem.
### systems
Paginated list of NAS Systems.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns NasSystemConnection.
### topleveldescendants
Paginated list of the highest-level NAS Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### volume
A NAS Volume.

- There is a single argument of type System.String.
- Returns NasVolume.
