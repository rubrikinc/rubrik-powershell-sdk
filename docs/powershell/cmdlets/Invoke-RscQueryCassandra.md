# Invoke-RscQueryCassandra
## Subcommands
### Columnfamily
Paginated list of cassandra column families.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraColumnFamilyConnection.
### Columnfamilyrecoverablerange
Get Recoverable Range of a Cassandra Column Family.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### Columnfamilyschema
Get Schema of a Cassandra Column Family.

- There is a single argument of type GetMosaicTableSchemaInput.
- Returns GetSchemaResponse.
### Keyspace
Paginated list of cassandra keyspaces.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraKeyspaceConnection.
### Source
Paginated list of cassandra sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraSourceConnection.
