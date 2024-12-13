### NasShareConnection
Paginated list of NasShare objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NasShareEdges
  - List of NasShare objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NasShares
  - List of NasShare objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of NasShare objects matching the request arguments.
