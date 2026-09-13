### OlvmTagLogicalChildConnection
Paginated list of OlvmTagLogicalChild objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of OlvmTagLogicalChildEdges
  - List of OlvmTagLogicalChild objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of OlvmTagLogicalChilds
  - List of OlvmTagLogicalChild objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of OlvmTagLogicalChild objects matching the request arguments.
