### GcpNativeHierarchyObjectConnection
Paginated list of GcpNativeHierarchyObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of GcpNativeHierarchyObjectEdges
  - List of GcpNativeHierarchyObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of GcpNativeHierarchyObjects
  - List of GcpNativeHierarchyObject objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of GcpNativeHierarchyObject objects matching the request arguments.
