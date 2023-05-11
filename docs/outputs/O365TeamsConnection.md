### O365TeamsConnection
Paginated list of O365Teams objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of O365Teams objects matching the request arguments.
- edges: a list of O365TeamsEdges
  - List of O365Teams objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of O365Teamss
  - List of O365Teams objects.
- pageInfo: PageInfo
  - General information about this page of results.
