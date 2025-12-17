### IpInfoConnection
Paginated list of IpInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of IpInfoEdges
  - List of IpInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of IpInfos
  - List of IpInfo objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of IpInfo objects matching the request arguments.
