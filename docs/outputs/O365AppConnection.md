### O365AppConnection
Paginated list of O365App objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of O365App objects matching the request arguments.
- edges: a list of O365AppEdges
  - List of O365App objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of O365Apps
  - List of O365App objects.
- pageInfo: PageInfo
  - General information about this page of results.
