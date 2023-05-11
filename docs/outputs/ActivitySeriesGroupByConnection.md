### ActivitySeriesGroupByConnection
Paginated list of ActivitySeriesGroupBy objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of ActivitySeriesGroupBy objects matching the request arguments.
- edges: a list of ActivitySeriesGroupByEdges
  - List of ActivitySeriesGroupBy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of ActivitySeriesGroupBys
  - List of ActivitySeriesGroupBy objects.
- pageInfo: PageInfo
  - General information about this page of results.
