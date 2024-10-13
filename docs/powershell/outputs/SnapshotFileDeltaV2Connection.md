### SnapshotFileDeltaV2Connection
Paginated list of SnapshotFileDeltaV2 objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SnapshotFileDeltaV2Edges
  - List of SnapshotFileDeltaV2 objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SnapshotFileDeltaV2s
  - List of SnapshotFileDeltaV2 objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of SnapshotFileDeltaV2 objects matching the request arguments.
- currentSnapshot: GenericSnapshot
  - The current snapshot.
- previousSnapshot: GenericSnapshot
  - The snapshot using which deltas are computed.
