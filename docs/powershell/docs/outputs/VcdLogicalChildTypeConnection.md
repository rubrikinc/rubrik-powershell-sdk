### VcdLogicalChildTypeConnection
Paginated list of VcdLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of VcdLogicalChildTypeEdges
  - List of VcdLogicalChildType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of VcdLogicalChildTypes
  - List of VcdLogicalChildType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of VcdLogicalChildType objects matching the request arguments.
