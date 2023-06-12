### MissedSnapshotGroupByConnection
Paginated list of MissedSnapshotGroupBy objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MissedSnapshotGroupByEdges
  - List of MissedSnapshotGroupBy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MissedSnapshotGroupBys
  - List of MissedSnapshotGroupBy objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of MissedSnapshotGroupBy objects matching the request arguments.
