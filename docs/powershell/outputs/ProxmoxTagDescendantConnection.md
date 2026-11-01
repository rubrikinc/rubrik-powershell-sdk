### ProxmoxTagDescendantConnection
Paginated list of ProxmoxTagDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ProxmoxTagDescendantEdges
  - List of ProxmoxTagDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ProxmoxTagDescendants
  - List of ProxmoxTagDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ProxmoxTagDescendant objects matching the request arguments.
