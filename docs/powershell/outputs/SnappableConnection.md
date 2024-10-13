### SnappableConnection
Paginated list of Snappable objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SnappableEdges
  - List of Snappable objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Snappables
  - List of Snappable objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of Snappable objects matching the request arguments.
- aggregation: SnappableAggregation
  - Aggregated information about the workloads.
