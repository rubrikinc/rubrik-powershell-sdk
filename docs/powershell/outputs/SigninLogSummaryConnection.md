### SigninLogSummaryConnection
Paginated list of SigninLogSummary objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SigninLogSummaryEdges
  - List of SigninLogSummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SigninLogSummarys
  - List of SigninLogSummary objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SigninLogSummary objects matching the request arguments.
