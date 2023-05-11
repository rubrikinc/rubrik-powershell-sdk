### CassandraSourceConnection
Paginated list of CassandraSource objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of CassandraSource objects matching the request arguments.
- edges: a list of CassandraSourceEdges
  - List of CassandraSource objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of CassandraSources
  - List of CassandraSource objects.
- pageInfo: PageInfo
  - General information about this page of results.
