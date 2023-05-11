### Db2RecoverableRangeConnection
Paginated list of Db2RecoverableRange objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of Db2RecoverableRange objects matching the request arguments.
- edges: a list of Db2RecoverableRangeEdges
  - List of Db2RecoverableRange objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of Db2RecoverableRanges
  - List of Db2RecoverableRange objects.
- pageInfo: PageInfo
  - General information about this page of results.
