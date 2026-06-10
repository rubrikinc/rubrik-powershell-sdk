### FusionComputeClusterDescendantConnection
Paginated list of FusionComputeClusterDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FusionComputeClusterDescendantEdges
  - List of FusionComputeClusterDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FusionComputeClusterDescendants
  - List of FusionComputeClusterDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of FusionComputeClusterDescendant objects matching the request arguments.
