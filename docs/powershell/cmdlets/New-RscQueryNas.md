# New-RscQueryNas
## Subcommands
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns NasNamespaceConnection.
### share
A NAS Share.

- There is a single argument of type System.String.
- Returns NasShare.
### system
A NAS System.

- There is a single argument of type System.String.
- Returns NasSystem.
### systems
Paginated list of NAS Systems.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns NasSystemConnection.
### topleveldescendants
Paginated list of the highest-level NAS Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns CdmHierarchyObjectConnection.
### volume
A NAS Volume.

- There is a single argument of type System.String.
- Returns NasVolume.
