### VsphereComputeClusterConnection
Paginated list of VsphereComputeCluster objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VsphereComputeClusterEdges
  - List of VsphereComputeCluster objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VsphereComputeClusters
  - List of VsphereComputeCluster objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VsphereComputeCluster objects matching the request arguments.
