### BlueprintChildConnection
Paginated list of BlueprintChild objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of BlueprintChild objects matching the request arguments.
- edges: a list of BlueprintChildEdges
  - List of BlueprintChild objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of BlueprintChilds
  - List of BlueprintChild objects.
- pageInfo: PageInfo
  - General information about this page of results.
