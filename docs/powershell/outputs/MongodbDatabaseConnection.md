### MongodbDatabaseConnection
Paginated list of MongodbDatabase objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MongodbDatabaseEdges
  - List of MongodbDatabase objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MongodbDatabases
  - List of MongodbDatabase objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of MongodbDatabase objects matching the request arguments.
