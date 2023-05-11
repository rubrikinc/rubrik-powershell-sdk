### MongoDatabaseDescendantTypeConnection
Paginated list of MongoDatabaseDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of MongoDatabaseDescendantType objects matching the request arguments.
- edges: a list of MongoDatabaseDescendantTypeEdges
  - List of MongoDatabaseDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of MongoDatabaseDescendantTypes
  - List of MongoDatabaseDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
