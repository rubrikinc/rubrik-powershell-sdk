### OlvmTagDescendantConnection
Paginated list of OlvmTagDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of OlvmTagDescendantEdges
  - List of OlvmTagDescendant objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of OlvmTagDescendants
  - List of OlvmTagDescendant objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of OlvmTagDescendant objects matching the request arguments.
