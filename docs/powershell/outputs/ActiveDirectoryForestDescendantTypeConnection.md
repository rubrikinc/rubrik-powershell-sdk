### ActiveDirectoryForestDescendantTypeConnection
Paginated list of ActiveDirectoryForestDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectoryForestDescendantTypeEdges
  - List of ActiveDirectoryForestDescendantType objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectoryForestDescendantTypes
  - List of ActiveDirectoryForestDescendantType objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of ActiveDirectoryForestDescendantType objects matching the request arguments.
