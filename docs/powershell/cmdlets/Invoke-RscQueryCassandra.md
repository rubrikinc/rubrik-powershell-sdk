# Invoke-RscQueryCassandra
## Subcommands
### columnfamily
Paginated list of cassandra column families.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraColumnFamilyConnection.
### columnfamilyrecoverablerange
Get Recoverable Range of a Cassandra Column Family.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### columnfamilyschema
Get Schema of a Cassandra Column Family.

- There is a single argument of type GetMosaicTableSchemaInput.
- Returns GetSchemaResponse.
### keyspace
Paginated list of cassandra keyspaces.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraKeyspaceConnection.
### source
Paginated list of cassandra sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraSourceConnection.
