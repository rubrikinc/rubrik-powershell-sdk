### PolarisSlaStatusConnection
Paginated list of PolarisSlaStatus objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of PolarisSlaStatus objects matching the request arguments.
- edges: a list of PolarisSlaStatusEdges
  - List of PolarisSlaStatus objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of PolarisSlaStatuss
  - List of PolarisSlaStatus objects.
- pageInfo: PageInfo
  - General information about this page of results.
