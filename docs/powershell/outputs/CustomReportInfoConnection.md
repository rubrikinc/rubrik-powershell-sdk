### CustomReportInfoConnection
Paginated list of CustomReportInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CustomReportInfoEdges
  - List of CustomReportInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CustomReportInfos
  - List of CustomReportInfo objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CustomReportInfo objects matching the request arguments.
