### MosaicSnapshotConnection
Paginated list of MosaicSnapshot objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MosaicSnapshotEdges
  - List of MosaicSnapshot objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MosaicSnapshots
  - List of MosaicSnapshot objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of MosaicSnapshot objects matching the request arguments.
