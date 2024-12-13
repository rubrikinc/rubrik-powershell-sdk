### VsphereVcenterConnection
Paginated list of VsphereVcenter objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VsphereVcenterEdges
  - List of VsphereVcenter objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VsphereVcenters
  - List of VsphereVcenter objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of VsphereVcenter objects matching the request arguments.
