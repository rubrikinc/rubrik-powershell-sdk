### WindowsClusterLogicalChildTypeConnection
Paginated list of WindowsClusterLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of WindowsClusterLogicalChildType objects matching the request arguments.
- edges: a list of WindowsClusterLogicalChildTypeEdges
  - List of WindowsClusterLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of WindowsClusterLogicalChildTypes
  - List of WindowsClusterLogicalChildType objects.
- pageInfo: PageInfo
  - General information about this page of results.
