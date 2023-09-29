# New-RscQueryExchange
## Subcommands
### dag
Details of an Exchange DAG for a given fid.

- There is a single argument of type System.String.
- Returns ExchangeDag.
### dags
Connection of filtered Exchange DAGs based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ExchangeDagConnection.
### database
Details of an Exchange Database for a given fid.

- There is a single argument of type System.String.
- Returns ExchangeDatabase.
### databases
Connection of filtered Exchange Databases based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ExchangeDatabaseConnection.
### livemounts
Paginated list of Exchange Database live mounts.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of ExchangeLiveMountFilterInputs: Filter for exchange live mounts.
    - sortBy - ExchangeLiveMountSortByInput: Sort by argument for exchange live mounts.
- Returns ExchangeLiveMountConnection.
### server
Details of an Exchange Server for a given fid.

- There is a single argument of type System.String.
- Returns ExchangeServer.
### servers
Connection of filtered Exchange Servers based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ExchangeServerConnection.
