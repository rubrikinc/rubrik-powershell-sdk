### AzureSqlManagedInstanceServerConnection
Paginated list of AzureSqlManagedInstanceServer objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureSqlManagedInstanceServerEdges
  - List of AzureSqlManagedInstanceServer objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureSqlManagedInstanceServers
  - List of AzureSqlManagedInstanceServer objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of AzureSqlManagedInstanceServer objects matching the request arguments.
