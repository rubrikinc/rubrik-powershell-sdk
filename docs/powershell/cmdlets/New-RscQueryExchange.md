# New-RscQueryExchange
## Subcommands
### dag
Details of an Exchange DAG for a given fid.

- There is a single argument of type System.String.
- Returns ExchangeDag.
### dags
Connection of filtered Exchange DAGs based on specific filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ExchangeDagConnection.
### database
Single Exchange Database lookup by FID.

- There is a single argument of type System.String.
- Returns ExchangeDatabase.
### databases
Connection of filtered Exchange Databases based on specific filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ExchangeDatabaseConnection.
### livemounts
List of Exchange Database live mounts.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - filters - list of ExchangeLiveMountFilterInputs: Filters for Exchange Database live mounts.
    - sortBy - ExchangeLiveMountSortByInput: Sort by argument for Exchange Database live mounts.
- Returns ExchangeLiveMountConnection.
### server
Single Exchange Server lookup by FID.

- There is a single argument of type System.String.
- Returns ExchangeServer.
### servers
Connection of filtered Exchange Servers based on specific filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: An opaque cursor returned from a previous query's endCursor field. Pass this value verbatim to retrieve the next page of results.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: An opaque cursor returned from a previous query's startCursor field. Pass this value verbatim to retrieve the previous page of results.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ExchangeServerConnection.
