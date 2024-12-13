### PrincipalConnection
Paginated list of Principal objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of PrincipalEdges
  - List of Principal objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Principals
  - List of Principal objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of Principal objects matching the request arguments.
