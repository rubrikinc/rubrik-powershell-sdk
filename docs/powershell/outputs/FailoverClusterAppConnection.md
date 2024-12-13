### FailoverClusterAppConnection
Paginated list of FailoverClusterApp objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of FailoverClusterAppEdges
  - List of FailoverClusterApp objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of FailoverClusterApps
  - List of FailoverClusterApp objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of FailoverClusterApp objects matching the request arguments.
