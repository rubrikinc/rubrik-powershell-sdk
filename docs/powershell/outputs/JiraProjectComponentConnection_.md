### JiraProjectComponentConnection
Paginated list of JiraProjectComponent objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of JiraProjectComponentEdges
  - List of JiraProjectComponent objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of JiraProjectComponents
  - List of JiraProjectComponent objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of JiraProjectComponent objects matching the request arguments.
