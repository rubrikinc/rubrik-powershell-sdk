### CloudDirectNasShareConnection
Paginated list of CloudDirectNasShare objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CloudDirectNasShareEdges
  - List of CloudDirectNasShare objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CloudDirectNasShares
  - List of CloudDirectNasShare objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CloudDirectNasShare objects matching the request arguments.
