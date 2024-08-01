### Db2DatabaseConnection
Paginated list of Db2Database objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of Db2DatabaseEdges
  - List of Db2Database objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Db2Databases
  - List of Db2Database objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Db2Database objects matching the request arguments.
