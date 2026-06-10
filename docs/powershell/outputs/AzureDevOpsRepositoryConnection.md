### AzureDevOpsRepositoryConnection
Paginated list of AzureDevOpsRepository objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureDevOpsRepositoryEdges
  - List of AzureDevOpsRepository objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureDevOpsRepositorys
  - List of AzureDevOpsRepository objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureDevOpsRepository objects matching the request arguments.
