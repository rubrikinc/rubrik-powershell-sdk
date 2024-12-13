### AzureAdObjectConnection
Paginated list of AzureAdObject objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureAdObjectEdges
  - List of AzureAdObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureAdObjects
  - List of AzureAdObject objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureAdObject objects matching the request arguments.
