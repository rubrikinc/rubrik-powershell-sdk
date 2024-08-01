### PostgreSQLDatabaseConnection
Paginated list of PostgreSQLDatabase objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PostgreSQLDatabaseEdges
  - List of PostgreSQLDatabase objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PostgreSQLDatabases
  - List of PostgreSQLDatabase objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of PostgreSQLDatabase objects matching the request arguments.
