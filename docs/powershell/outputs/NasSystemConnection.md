### NasSystemConnection
Paginated list of NasSystem objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NasSystemEdges
  - List of NasSystem objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NasSystems
  - List of NasSystem objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of NasSystem objects matching the request arguments.
