### ReportMigrationStatusConnection
Paginated list of ReportMigrationStatus objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ReportMigrationStatusEdges
  - List of ReportMigrationStatus objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ReportMigrationStatuss
  - List of ReportMigrationStatus objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ReportMigrationStatus objects matching the request arguments.
