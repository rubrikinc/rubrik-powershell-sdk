### O365UserDescendantConnection
Paginated list of O365UserDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365UserDescendantEdges
  - List of O365UserDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365UserDescendants
  - List of O365UserDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365UserDescendant objects matching the request arguments.
