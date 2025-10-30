### RcvBliMigrationDetailsConnection
Paginated list of RcvBliMigrationDetails objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of RcvBliMigrationDetailsEdges
  - List of RcvBliMigrationDetails objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of RcvBliMigrationDetailss
  - List of RcvBliMigrationDetails objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of RcvBliMigrationDetails objects matching the request arguments.
