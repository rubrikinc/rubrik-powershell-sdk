### PolarisSnapshotConnection
Paginated list of PolarisSnapshot objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PolarisSnapshotEdges
  - List of PolarisSnapshot objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of PolarisSnapshots
  - List of PolarisSnapshot objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of PolarisSnapshot objects matching the request arguments.
