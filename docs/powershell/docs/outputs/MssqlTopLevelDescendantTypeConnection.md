### MssqlTopLevelDescendantTypeConnection
Paginated list of MssqlTopLevelDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of MssqlTopLevelDescendantTypeEdges
  - List of MssqlTopLevelDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of MssqlTopLevelDescendantTypes
  - List of MssqlTopLevelDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of MssqlTopLevelDescendantType objects matching the request arguments.
