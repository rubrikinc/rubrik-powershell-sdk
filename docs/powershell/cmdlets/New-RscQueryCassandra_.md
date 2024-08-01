# New-RscQueryCassandra
## Subcommands
### columnfamilies
Paginated list of cassandra column families.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraColumnFamilyConnection.
### columnfamily
Details of a cassandra column family.

- There is a single argument of type System.String.
- Returns CassandraColumnFamily.
### columnfamilyrecoverablerange
Get Recoverable Range of a Cassandra Column Family.

- There is a single argument of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### columnfamilyschema
Get Schema of a Cassandra Column Family.

- There is a single argument of type GetMosaicTableSchemaInput.
- Returns GetSchemaResponse.
### keyspace
Details of a cassandra keyspace.

- There is a single argument of type System.String.
- Returns CassandraKeyspace.
### keyspaces
Paginated list of cassandra keyspaces.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraKeyspaceConnection.
### source
Details of a cassandra source.

- There is a single argument of type System.String.
- Returns CassandraSource.
### sources
Paginated list of cassandra sources.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns CassandraSourceConnection.
