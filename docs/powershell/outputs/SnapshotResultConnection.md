### SnapshotResultConnection
Paginated list of SnapshotResult objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SnapshotResultEdges
  - List of SnapshotResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SnapshotResults
  - List of SnapshotResult objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SnapshotResult objects matching the request arguments.
