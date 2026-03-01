### MysqldbDatabaseConnection
Paginated list of MysqldbDatabase objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MysqldbDatabaseEdges
  - List of MysqldbDatabase objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MysqldbDatabases
  - List of MysqldbDatabase objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of MysqldbDatabase objects matching the request arguments.
