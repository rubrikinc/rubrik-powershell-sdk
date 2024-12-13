### OracleDatabaseConnection
Paginated list of OracleDatabase objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of OracleDatabaseEdges
  - List of OracleDatabase objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of OracleDatabases
  - List of OracleDatabase objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of OracleDatabase objects matching the request arguments.
