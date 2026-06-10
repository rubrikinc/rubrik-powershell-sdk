### AzureDevOpsProjectConnection
Paginated list of AzureDevOpsProject objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureDevOpsProjectEdges
  - List of AzureDevOpsProject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureDevOpsProjects
  - List of AzureDevOpsProject objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureDevOpsProject objects matching the request arguments.
