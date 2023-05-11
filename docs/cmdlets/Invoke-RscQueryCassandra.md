# Invoke-RscQueryCassandra
## Subcommands
### ColumnFamily
Paginated list of cassandra column families.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - a list of Filters: The hierarchy object filter.
    - first - System.Int32: Returns the first n elements from the list.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns CassandraColumnFamilyConnection.
### ColumnFamilyRecoverableRange
Get Recoverable Range of a Cassandra Column Family.

- The Input parameter takes a single value of type GetMosaicRecoverableRangeInput.
- Returns GetMosaicRecoverableRangeResponse.
### ColumnFamilySchema
Get Schema of a Cassandra Column Family.

- The Input parameter takes a single value of type GetMosaicTableSchemaInput.
- Returns GetSchemaResponse.
### Keyspace
Details of a cassandra keyspace.

- The Input parameter takes a single value of type System.String.
- Returns CassandraKeyspace.
### Source
Details of a cassandra source.

- The Input parameter takes a single value of type System.String.
- Returns CassandraSource.
