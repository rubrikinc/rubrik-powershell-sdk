### ProxmoxEnvironmentDescendantConnection
Paginated list of ProxmoxEnvironmentDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ProxmoxEnvironmentDescendantEdges
  - List of ProxmoxEnvironmentDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ProxmoxEnvironmentDescendants
  - List of ProxmoxEnvironmentDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ProxmoxEnvironmentDescendant objects matching the request arguments.
