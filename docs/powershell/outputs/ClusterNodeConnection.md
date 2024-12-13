### ClusterNodeConnection
Paginated list of ClusterNode objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ClusterNodeEdges
  - List of ClusterNode objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ClusterNodes
  - List of ClusterNode objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ClusterNode objects matching the request arguments.
