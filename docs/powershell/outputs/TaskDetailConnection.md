### TaskDetailConnection
Paginated list of TaskDetail objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of TaskDetailEdges
  - List of TaskDetail objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of TaskDetails
  - List of TaskDetail objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of TaskDetail objects matching the request arguments.
