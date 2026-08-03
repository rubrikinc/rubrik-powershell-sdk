# New-RscQueryStorageArray
## Subcommands
### purestoragearraysv1
Connection of Pure Storage arrays.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns PureStorageArrayV1Connection.
### purestoragearrayv1
Details of a Pure Storage array for a given ID.

- There is a single argument of type System.String.
- Returns PureStorageArrayV1.
### storagearray
Summary of all storage arrays

Supported in v5.0+
Retrieve the host IP and username for all storage arrays.

- There is a single argument of type list of System.Strings.
- Returns AllStorageArraysReply.
