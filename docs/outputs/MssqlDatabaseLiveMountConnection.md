### MssqlDatabaseLiveMountConnection
Paginated list of MssqlDatabaseLiveMount objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of MssqlDatabaseLiveMount objects matching the request arguments.
- edges: a list of MssqlDatabaseLiveMountEdges
  - List of MssqlDatabaseLiveMount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of MssqlDatabaseLiveMounts
  - List of MssqlDatabaseLiveMount objects.
- pageInfo: PageInfo
  - General information about this page of results.
