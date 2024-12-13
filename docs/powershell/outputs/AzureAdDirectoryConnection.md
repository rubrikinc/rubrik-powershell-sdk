### AzureAdDirectoryConnection
Paginated list of AzureAdDirectory objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureAdDirectoryEdges
  - List of AzureAdDirectory objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureAdDirectorys
  - List of AzureAdDirectory objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureAdDirectory objects matching the request arguments.
