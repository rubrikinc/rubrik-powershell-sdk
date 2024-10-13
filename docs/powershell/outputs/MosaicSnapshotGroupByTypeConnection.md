### MosaicSnapshotGroupByTypeConnection
Paginated list of MosaicSnapshotGroupByType objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MosaicSnapshotGroupByTypeEdges
  - List of MosaicSnapshotGroupByType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MosaicSnapshotGroupByTypes
  - List of MosaicSnapshotGroupByType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of MosaicSnapshotGroupByType objects matching the request arguments.
