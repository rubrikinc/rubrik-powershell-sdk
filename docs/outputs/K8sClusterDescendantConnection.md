### K8sClusterDescendantConnection
Paginated list of K8sClusterDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of K8sClusterDescendant objects matching the request arguments.
- edges: a list of K8sClusterDescendantEdges
  - List of K8sClusterDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of K8sClusterDescendants
  - List of K8sClusterDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
