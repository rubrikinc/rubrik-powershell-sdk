### ObjectTypeAccessSummaryConnection
Paginated list of ObjectTypeAccessSummary objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ObjectTypeAccessSummaryEdges
  - List of ObjectTypeAccessSummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ObjectTypeAccessSummarys
  - List of ObjectTypeAccessSummary objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ObjectTypeAccessSummary objects matching the request arguments.
