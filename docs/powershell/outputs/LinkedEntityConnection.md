### LinkedEntityConnection
Paginated list of LinkedEntity objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of LinkedEntityEdges
  - List of LinkedEntity objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of LinkedEntitys
  - List of LinkedEntity objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of LinkedEntity objects matching the request arguments.
