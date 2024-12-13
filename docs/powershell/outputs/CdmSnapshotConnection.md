### CdmSnapshotConnection
Paginated list of CdmSnapshot objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdmSnapshotEdges
  - List of CdmSnapshot objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdmSnapshots
  - List of CdmSnapshot objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CdmSnapshot objects matching the request arguments.
