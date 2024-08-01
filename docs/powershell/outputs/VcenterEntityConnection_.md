### VcenterEntityConnection
Paginated list of VcenterEntity objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VcenterEntityEdges
  - List of VcenterEntity objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VcenterEntitys
  - List of VcenterEntity objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VcenterEntity objects matching the request arguments.
