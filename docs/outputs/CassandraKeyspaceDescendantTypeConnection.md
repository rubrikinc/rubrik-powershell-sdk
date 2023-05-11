### CassandraKeyspaceDescendantTypeConnection
Paginated list of CassandraKeyspaceDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of CassandraKeyspaceDescendantType objects matching the request arguments.
- edges: a list of CassandraKeyspaceDescendantTypeEdges
  - List of CassandraKeyspaceDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of CassandraKeyspaceDescendantTypes
  - List of CassandraKeyspaceDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
