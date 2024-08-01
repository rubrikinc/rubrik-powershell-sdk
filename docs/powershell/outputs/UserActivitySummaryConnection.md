### UserActivitySummaryConnection
Paginated list of UserActivitySummary objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of UserActivitySummaryEdges
  - List of UserActivitySummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of UserActivitySummarys
  - List of UserActivitySummary objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of UserActivitySummary objects matching the request arguments.
