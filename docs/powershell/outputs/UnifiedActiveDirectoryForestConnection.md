### UnifiedActiveDirectoryForestConnection
Paginated list of UnifiedActiveDirectoryForest objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of UnifiedActiveDirectoryForestEdges
  - List of UnifiedActiveDirectoryForest objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of UnifiedActiveDirectoryForests
  - List of UnifiedActiveDirectoryForest objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of UnifiedActiveDirectoryForest objects matching the request arguments.
