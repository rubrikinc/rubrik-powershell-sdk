### GenericSnapshotConnection
Paginated list of GenericSnapshot objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of GenericSnapshotEdges
  - List of GenericSnapshot objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of GenericSnapshots
  - List of GenericSnapshot objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of GenericSnapshot objects matching the request arguments.
