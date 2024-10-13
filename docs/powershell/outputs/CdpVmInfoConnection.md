### CdpVmInfoConnection
Paginated list of CdpVmInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CdpVmInfoEdges
  - List of CdpVmInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CdpVmInfos
  - List of CdpVmInfo objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of CdpVmInfo objects matching the request arguments.
