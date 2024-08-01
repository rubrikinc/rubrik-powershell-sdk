### ClusterSlaDomainConnection
Paginated list of ClusterSlaDomain objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ClusterSlaDomainEdges
  - List of ClusterSlaDomain objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ClusterSlaDomains
  - List of ClusterSlaDomain objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ClusterSlaDomain objects matching the request arguments.
