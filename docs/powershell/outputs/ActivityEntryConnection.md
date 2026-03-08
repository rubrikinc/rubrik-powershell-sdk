### ActivityEntryConnection
Paginated list of ActivityEntry objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActivityEntryEdges
  - List of ActivityEntry objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActivityEntrys
  - List of ActivityEntry objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ActivityEntry objects matching the request arguments.
