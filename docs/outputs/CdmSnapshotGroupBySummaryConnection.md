### CdmSnapshotGroupBySummaryConnection
Paginated list of CdmSnapshotGroupBySummary objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of CdmSnapshotGroupBySummary objects matching the request arguments.
- edges: a list of CdmSnapshotGroupBySummaryEdges
  - List of CdmSnapshotGroupBySummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of CdmSnapshotGroupBySummarys
  - List of CdmSnapshotGroupBySummary objects.
- pageInfo: PageInfo
  - General information about this page of results.
