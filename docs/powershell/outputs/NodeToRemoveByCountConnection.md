### NodeToRemoveByCountConnection
Paginated list of NodeToRemoveByCount objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NodeToRemoveByCountEdges
  - List of NodeToRemoveByCount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NodeToRemoveByCounts
  - List of NodeToRemoveByCount objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of NodeToRemoveByCount objects matching the request arguments.
