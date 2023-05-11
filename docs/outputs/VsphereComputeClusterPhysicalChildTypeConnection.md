### VsphereComputeClusterPhysicalChildTypeConnection
Paginated list of VsphereComputeClusterPhysicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of VsphereComputeClusterPhysicalChildType objects matching the request arguments.
- edges: a list of VsphereComputeClusterPhysicalChildTypeEdges
  - List of VsphereComputeClusterPhysicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of VsphereComputeClusterPhysicalChildTypes
  - List of VsphereComputeClusterPhysicalChildType objects.
- pageInfo: PageInfo
  - General information about this page of results.
