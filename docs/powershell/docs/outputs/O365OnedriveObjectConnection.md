### O365OnedriveObjectConnection
Paginated list of O365OnedriveObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365OnedriveObjectEdges
  - List of O365OnedriveObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365OnedriveObjects
  - List of O365OnedriveObject objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365OnedriveObject objects matching the request arguments.
