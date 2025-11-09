### HaPolicyConnection
Paginated list of HaPolicy objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of HaPolicyEdges
  - List of HaPolicy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of HaPolicys
  - List of HaPolicy objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of HaPolicy objects matching the request arguments.
