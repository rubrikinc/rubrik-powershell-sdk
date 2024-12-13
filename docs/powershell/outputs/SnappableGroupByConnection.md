### SnappableGroupByConnection
Paginated list of SnappableGroupBy objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SnappableGroupByEdges
  - List of SnappableGroupBy objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SnappableGroupBys
  - List of SnappableGroupBy objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of SnappableGroupBy objects matching the request arguments.
