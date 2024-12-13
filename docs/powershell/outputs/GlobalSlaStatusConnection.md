### GlobalSlaStatusConnection
Paginated list of GlobalSlaStatus objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of GlobalSlaStatusEdges
  - List of GlobalSlaStatus objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of GlobalSlaStatuss
  - List of GlobalSlaStatus objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of GlobalSlaStatus objects matching the request arguments.
