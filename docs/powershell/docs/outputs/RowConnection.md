### RowConnection
Paginated list of Row objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of RowEdges
  - List of Row objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Rows
  - List of Row objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Row objects matching the request arguments.
- columns: list of Columns
