### MongoCollectionConnection
Paginated list of MongoCollection objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MongoCollectionEdges
  - List of MongoCollection objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MongoCollections
  - List of MongoCollection objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of MongoCollection objects matching the request arguments.
