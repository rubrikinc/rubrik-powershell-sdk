### VsphereVmConnection
Paginated list of VsphereVm objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of VsphereVm objects matching the request arguments.
- edges: a list of VsphereVmEdges
  - List of VsphereVm objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of VsphereVms
  - List of VsphereVm objects.
- pageInfo: PageInfo
  - General information about this page of results.
