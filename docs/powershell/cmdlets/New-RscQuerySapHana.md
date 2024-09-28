# New-RscQuerySapHana
## Subcommands
### database
Details of a SAP HANA database for a given FID.

- There is a single argument of type System.String.
- Returns SapHanaDatabase.
### databases
Connection of filtered SAP HANA databases based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns SapHanaDatabaseConnection.
### logsnapshot
Details of a SAP HANA log snapshot for a given FID.

- There is a single argument of type System.String.
- Returns SapHanaLogSnapshot.
### logsnapshots
Connection of all log snapshots for SAP HANA.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SapHanaLogSnapshotSortBy: Field to sort SAP HANA log snapshots.
    - filter - SapHanaLogSnapshotFilterInput: Field to filter SAP HANA log snapshots.
- Returns SapHanaLogSnapshotConnection.
### recoverablerange
Details of a SAP HANA recoverable range for a given FID.

- There is a single argument of type System.String.
- Returns SapHanaRecoverableRange.
### recoverableranges
Connection of all recoverable ranges for SAP HANA.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SapHanaRecoverableRangeSortBy: Field to sort SAP HANA recoverable ranges.
    - filter - SapHanaRecoverableRangeFilterInput: Field to filter SAP HANA recoverable ranges.
- Returns SapHanaRecoverableRangeConnection.
### system
Details of a SAP HANA system for a given FID.

- There is a single argument of type System.String.
- Returns SapHanaSystem.
### systems
Connection of filtered SAP HANA systems based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns SapHanaSystemConnection.
