### NutanixVmConnection
Paginated list of NutanixVm objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NutanixVmEdges
  - List of NutanixVm objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NutanixVms
  - List of NutanixVm objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of NutanixVm objects matching the request arguments.
