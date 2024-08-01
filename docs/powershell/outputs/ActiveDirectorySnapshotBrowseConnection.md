### ActiveDirectorySnapshotBrowseConnection
Paginated list of ActiveDirectorySnapshotBrowse objects. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectorySnapshotBrowseEdges
  - List of ActiveDirectorySnapshotBrowse objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectorySnapshotBrowses
  - List of ActiveDirectorySnapshotBrowse objects.
- count: System.Int32
  - Total number of ActiveDirectorySnapshotBrowse objects matching the request arguments.
- pageInfo: PageInfo
  - General information about this page of results. Use only endCursor and hasNextPage fields. The other fields are deprecated.
