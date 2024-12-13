### ActivityTimelineResultConnection
Paginated list of ActivityTimelineResult objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActivityTimelineResultEdges
  - List of ActivityTimelineResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActivityTimelineResults
  - List of ActivityTimelineResult objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ActivityTimelineResult objects matching the request arguments.
