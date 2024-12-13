### TaskDetailGroupByConnection
Paginated list of TaskDetailGroupBy objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of TaskDetailGroupByEdges
  - List of TaskDetailGroupBy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of TaskDetailGroupBys
  - List of TaskDetailGroupBy objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of TaskDetailGroupBy objects matching the request arguments.
