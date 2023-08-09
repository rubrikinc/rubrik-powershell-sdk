# Invoke-RscQueryDb2
## Subcommands
### database
Details of a db2 database for a given fid.

- There is a single argument of type System.String.
- Returns Db2Database.
### databases
Connection of filtered db2 databases based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns Db2DatabaseConnection.
### instance
Details of a db2 instance for a given fid.

- There is a single argument of type System.String.
- Returns Db2Instance.
### instances
Connection of filtered db2 instances based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns Db2InstanceConnection.
### logsnapshot
Details of a Db2 log snapshot for a given fid.

- There is a single argument of type System.String.
- Returns Db2LogSnapshot.
### logsnapshots
Connection of all log snapshots for Db2.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - Db2LogSnapshotSortBy: Field to sort Db2 log snapshots.
    - filter - Db2LogSnapshotFilterInput: Field to filter Db2 log snapshots.
- Returns Db2LogSnapshotConnection.
### recoverablerange
Details of a Db2 recoverable range for a given fid.

- There is a single argument of type System.String.
- Returns Db2RecoverableRange.
### recoverableranges
Connection of all recoverable ranges for Db2.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - Db2RecoverableRangeSortBy: Field to sort Db2 recoverable ranges.
    - filter - Db2RecoverableRangeFilterInput: Field to filter Db2 recoverable ranges.
- Returns Db2RecoverableRangeConnection.
