### VsphereProxyVmInfoConnection
Paginated list of VsphereProxyVmInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VsphereProxyVmInfoEdges
  - List of VsphereProxyVmInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VsphereProxyVmInfos
  - List of VsphereProxyVmInfo objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VsphereProxyVmInfo objects matching the request arguments.
