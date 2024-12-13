### CloudDirectSnapshotsGroupBySummaryConnection
Paginated list of CloudDirectSnapshotsGroupBySummary objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of CloudDirectSnapshotsGroupBySummaryEdges
  - List of CloudDirectSnapshotsGroupBySummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of CloudDirectSnapshotsGroupBySummarys
  - List of CloudDirectSnapshotsGroupBySummary objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of CloudDirectSnapshotsGroupBySummary objects matching the request arguments.
