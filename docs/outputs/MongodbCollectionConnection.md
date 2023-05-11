### MongodbCollectionConnection
Paginated list of MongodbCollection objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of MongodbCollection objects matching the request arguments.
- edges: a list of MongodbCollectionEdges
  - List of MongodbCollection objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of MongodbCollections
  - List of MongodbCollection objects.
- pageInfo: PageInfo
  - General information about this page of results.
