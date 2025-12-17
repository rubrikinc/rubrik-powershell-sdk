### FailoverGroupArchivalLocationConnection
Paginated list of FailoverGroupArchivalLocation objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FailoverGroupArchivalLocationEdges
  - List of FailoverGroupArchivalLocation objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FailoverGroupArchivalLocations
  - List of FailoverGroupArchivalLocation objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FailoverGroupArchivalLocation objects matching the request arguments.
