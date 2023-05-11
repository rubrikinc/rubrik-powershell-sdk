### SnapshotFileDeltaConnection
Paginated list of SnapshotFileDelta objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of SnapshotFileDelta objects matching the request arguments.
- currentSnapshot: CdmSnapshot
  - The current snapshot.
- edges: a list of SnapshotFileDeltaEdges
  - List of SnapshotFileDelta objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of SnapshotFileDeltas
  - List of SnapshotFileDelta objects.
- pageInfo: PageInfo
  - General information about this page of results.
- previousSnapshot: CdmSnapshot
  - The snapshot using which deltas are computed.
