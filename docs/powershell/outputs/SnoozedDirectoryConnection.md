### SnoozedDirectoryConnection
Paginated list of SnoozedDirectory objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SnoozedDirectoryEdges
  - List of SnoozedDirectory objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SnoozedDirectorys
  - List of SnoozedDirectory objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SnoozedDirectory objects matching the request arguments.
