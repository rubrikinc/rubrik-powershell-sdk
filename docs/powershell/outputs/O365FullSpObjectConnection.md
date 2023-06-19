### O365FullSpObjectConnection
Paginated list of O365FullSpObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of O365FullSpObjectEdges
  - List of O365FullSpObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of O365FullSpObjects
  - List of O365FullSpObject objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of O365FullSpObject objects matching the request arguments.
