### StorageAccountConnection
Paginated list of StorageAccount objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of StorageAccountEdges
  - List of StorageAccount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of StorageAccounts
  - List of StorageAccount objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of StorageAccount objects matching the request arguments.
