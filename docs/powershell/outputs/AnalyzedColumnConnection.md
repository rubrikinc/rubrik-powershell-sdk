### AnalyzedColumnConnection
Paginated list of AnalyzedColumn objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AnalyzedColumnEdges
  - List of AnalyzedColumn objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AnalyzedColumns
  - List of AnalyzedColumn objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AnalyzedColumn objects matching the request arguments.
