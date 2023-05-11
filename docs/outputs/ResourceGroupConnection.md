### ResourceGroupConnection
Paginated list of ResourceGroup objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of ResourceGroup objects matching the request arguments.
- edges: a list of ResourceGroupEdges
  - List of ResourceGroup objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of ResourceGroups
  - List of ResourceGroup objects.
- pageInfo: PageInfo
  - General information about this page of results.
