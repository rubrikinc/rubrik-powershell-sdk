### TaskSummaryConnection
Paginated list of TaskSummary objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- aggregation: TaskSummaryAggregation
  - None
- count: System.Int32
  - Total number of TaskSummary objects matching the request arguments.
- edges: a list of TaskSummaryEdges
  - List of TaskSummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of TaskSummarys
  - List of TaskSummary objects.
- pageInfo: PageInfo
  - General information about this page of results.
