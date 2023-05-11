### HypervTopLevelDescendantTypeConnection
Paginated list of HypervTopLevelDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of HypervTopLevelDescendantType objects matching the request arguments.
- edges: a list of HypervTopLevelDescendantTypeEdges
  - List of HypervTopLevelDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of HypervTopLevelDescendantTypes
  - List of HypervTopLevelDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
